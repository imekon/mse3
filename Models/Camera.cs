using System.Windows.Media.Media3D;
using mse.Models.Parameters;

namespace mse.Models
{
    public class Camera : Shape
    {
        public Camera()
        {
            _parameters.AddParameter("position", new VectorValue(new Vector3D(0.0, 0.0, 5.0)));
            _parameters.AddParameter("lookat", new VectorValue(new Vector3D(0.0, 0.0, 0.0)));
        }
    }
}