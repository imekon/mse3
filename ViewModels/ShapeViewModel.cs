using mse.Models;

namespace mse.ViewModels
{
    public class ShapeViewModel : ViewModelBase
    {
        protected Shape shape;

        public ShapeViewModel(Shape shape)
        {
            this.shape = shape;
        }

        public string Name
        {
            get { return shape.Parameters.GetParameter<string>("name"); }
            set
            {
                var name = "";
                if (SetProperty(ref name, value))
                {
                    shape.Parameters.SetParameter("name", name);
                }
            }
        }
    }
}