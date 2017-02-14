namespace mse.Models
{
    public class Shape
    {
        protected ParameterManager parameters;

        public Shape()
        {
            parameters = new ParameterManager();

            parameters.AddParameter<string>("name", "unknown");
        }

        public ParameterManager Parameters => parameters;
    }
}