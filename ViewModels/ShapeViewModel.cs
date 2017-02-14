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
                if (SetField(ref name, value, "Name"))
                {
                    shape.Parameters.SetParameter("name", name);
                }
            }
        }
    }
}