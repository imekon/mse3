using System.Windows.Media.Media3D;
using mse.Models;
using mse.Models.Parameters;

namespace mse.ViewModels
{
    public class ShapeViewModel : ViewModelBase
    {
        protected readonly Shape _shape;
        protected readonly Visual3D _visual;

        public ShapeViewModel(Shape shape, Visual3D visual)
        {
            _shape = shape;
            _visual = visual;
        }

        public ShapeViewModel(Shape shape) : this(shape, null)
        {
            
        }

        public string Name
        {
            get { return _shape.Parameters.GetParameter<string>("name").Value; }
            set
            {
                var name = "";
                if (SetProperty(ref name, value))
                {
                    _shape.Parameters.SetParameter("name", new StringValue(name));
                }
            }
        }

        public Visual3D Visual => _visual;
    }
}