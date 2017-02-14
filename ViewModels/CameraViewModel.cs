using System.Windows.Media.Media3D;
using Camera = mse.Models.Camera;

namespace mse.ViewModels
{
    public class CameraViewModel : ShapeViewModel
    {
        public CameraViewModel(Camera camera) : base(camera)
        {
            
        }

        public Vector3D Position
        {
            get { return shape.Parameters.GetParameter<Vector3D>("position"); }
            set
            {
                var vector = new Vector3D();
                if (SetField(ref vector, value, "Position"))
                {
                    shape.Parameters.SetParameter("position", vector);
                }
            }
        }

        public Vector3D LookAt
        {
            get { return shape.Parameters.GetParameter<Vector3D>("lookat"); }
            set
            {
                var vector = new Vector3D();
                if (SetField(ref vector, value, "LookAt"))
                {
                    shape.Parameters.SetParameter("lookat", vector);
                }
            }
        }
    }
}