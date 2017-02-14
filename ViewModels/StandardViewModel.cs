using System.Windows.Media.Media3D;
using mse.Models;

namespace mse.ViewModels
{
    public class StandardViewModel : ShapeViewModel
    {
        public StandardViewModel(Shape shape) : base(shape)
        {
            
        }

        public Vector3D Translate
        {
            get { return shape.Parameters.GetParameter<Vector3D>("translate"); }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("translate", vector);
                }
            }
        }

        public Vector3D Scale
        {
            get { return shape.Parameters.GetParameter<Vector3D>("scale"); }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("scale", vector);
                }
            }
        }

        public Vector3D Rotate
        {
            get { return shape.Parameters.GetParameter<Vector3D>("rotate"); }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("rotate", vector);
                }
            }
        }

    }
}