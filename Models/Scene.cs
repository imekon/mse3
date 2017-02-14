using System.Collections.Generic;

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
    }
}