using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace mse.Models
{
    public class Scene
    {
        private List<Shape> shapes;
        private Camera camera;

        public Scene()
        {
            shapes = new List<Shape>();
        }

        public List<Shape> Shapes => shapes;

        public Shape CreateShape(string name)
        {
            Shape shape = null;

            switch (name)
            {
                case "camera":
                    camera = new Camera();
                    shape = camera;
                    break;

                case "pointlight":
                    shape = new PointLight();
                    break;

                case "cube":
                    shape = new Cube();
                    break;

                default:
                    break;
            }

            if (shape != null)
                shapes.Add(shape);

            return shape;
        }

        public void Load(string filename)
        {
            var data = File.ReadAllText(filename);
            var scene = JsonConvert.DeserializeObject<Scene>(data);

            shapes.Clear();

            foreach (var shape in scene.Shapes)
            {
                shapes.Add(shape);
            }
        }

        public void Save(string filename)
        {
            var data = JsonConvert.SerializeObject(this);
            File.WriteAllText(filename, data);
        }
    }
}