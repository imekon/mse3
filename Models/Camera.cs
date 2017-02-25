using System.Windows.Media.Media3D;
using mse.Models.Parameters;

namespace mse.Models
{
    public class Camera : Shape
    {
        public Camera()
        {
            parameters.AddParameter<VectorValue>("position", new VectorValue(new Vector3D(0.0, 0.0, 5.0)));
            parameters.AddParameter<VectorValue>("lookat", new VectorValue(new Vector3D(0.0, 0.0, 0.0)));
        }
    }
}