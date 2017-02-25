using mse.Models.Parameters;

namespace mse.Models
{
    public class RGB
    {
        protected ParameterManager parameters;

        public RGB() : this(0.0, 0.0, 0.0)
        {
        }

        public RGB(double red, double green, double blue)
        {
            parameters = new ParameterManager();

            parameters.AddParameter<string>("name", "untitled");
            parameters.AddParameter<double>("red", red);
            parameters.AddParameter<double>("green", green);
            parameters.AddParameter<double>("blue", blue);

        }

        public ParameterManager Parameters => parameters;
    }

    public class RGBA : RGB
    {
        public RGBA(double red, double green, double blue, double alpha) : base(red, green, blue)
        {
            parameters.AddParameter<double>("alpha", 1.0);
        }

        public RGBA() : this(0.0, 0.0, 0.0, 1.0)
        {
            
        }
    }
}