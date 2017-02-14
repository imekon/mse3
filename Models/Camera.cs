using System.Windows.Media.Media3D;

namespace mse.Models
{
    public class Camera : Shape
    {
        public Camera()
        {
            parameters.AddParameter<Vector3D>("position", new Vector3D(0.0, 0.0, 5.0));
            parameters.AddParameter<Vector3D>("lookat", new Vector3D(0.0, 0.0, 0.0));
        }
    }
}