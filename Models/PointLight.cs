using System.Windows.Media.Media3D;

namespace mse.Models
{
    public class PointLight : Shape
    {
        public PointLight()
        {
            parameters.AddParameter<Vector3D>("position", new Vector3D(2.0, 2.0, 2.0));
            parameters.AddParameter<RGB>("colour", new RGB(1.0, 1.0, 1.0));
        }
    }
}