using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace mse.Models
{
    public class Scene
    {
        private List<Shape> _shapes;
        private Camera _camera;

        public Scene()
        {
            _shapes = new List<Shape>();
        }

        public List<Shape> Shapes => _shapes;

        public Shape CreateShape(string name)
        {
            Shape shape = null;

            switch (name)
            {
                case "_camera":
                    _camera = new Camera();
                    shape = _camera;
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
                _shapes.Add(shape);

            return shape;
        }

        public void Load(string filename)
        {
            _shapes.Clear();
        }

        public void Save(string filename)
        {
            using (var textWriter = new StreamWriter(filename))
            {
                using (var jsonWriter = new JsonTextWriter(textWriter))
                {
                    jsonWriter.Formatting = Formatting.Indented;

                    jsonWriter.WriteStartArray();

                    foreach (var shape in _shapes)
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