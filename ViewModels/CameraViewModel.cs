using System.Windows.Media.Media3D;
using HelixToolkit.Wpf;
using mse.Models.Parameters;
using Camera = mse.Models.Camera;

namespace mse.ViewModels
{
    public class CameraViewModel : ShapeViewModel
    {
        public CameraViewModel(Camera camera) : base(camera, new BoxVisual3D())
        {
        }

        public Vector3D Position
        {
            get { return shape.Parameters.GetParameter<Vector3D>("position").Value; }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("position", new VectorValue(vector));
                }
            }
        }

        public Vector3D LookAt
        {
            get { return shape.Parameters.GetParameter<Vector3D>("lookat").Value; }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("lookat", new VectorValue(vector));
                }
            }
        }
    }
}