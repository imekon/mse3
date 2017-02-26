using System.Windows.Media.Media3D;
using mse.Models;
using mse.Models.Parameters;

namespace mse.ViewModels
{
    public class StandardViewModel : ShapeViewModel
    {
        public StandardViewModel(Shape shape) : base(shape)
        {
            
        }

        public Vector3D Translate
        {
            get { return shape.Parameters.GetParameter<Vector3D>("translate").Value; }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("translate", new VectorValue(vector));
                }
            }
        }

        public Vector3D Scale
        {
            get { return shape.Parameters.GetParameter<Vector3D>("scale").Value; }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("scale", new VectorValue(vector));
                }
            }
        }

        public Vector3D Rotate
        {
            get { return shape.Parameters.GetParameter<Vector3D>("rotate").Value; }
            set
            {
                var vector = new Vector3D();
                if (SetProperty(ref vector, value))
                {
                    shape.Parameters.SetParameter("rotate", new VectorValue(value));
                }
            }
        }

    }
}