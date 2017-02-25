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
            shapes.Clear();
        }

        public void Save(string filename)
        {
            using (var textWriter = new StreamWriter(filename))
            {
                using (var jsonWriter = new JsonTextWriter(textWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;

                    jsonWriter.WriteStartArray();

                    foreach (var shape in shapes)
                    {
                        shape.ExportToJson(jsonWriter);
                    }

                    jsonWriter.WriteEndArray();
                }

                textWriter.Close();
            }
        }
    }
}