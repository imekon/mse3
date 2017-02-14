using System.Collections.Generic;

namespace mse.Models
{
    public class Parameter
    {
        protected string name;

        public Parameter(string name)
        {
            this.name = name;
        }
    }

    public class Parameter<TType> : Parameter
    {
        private TType value;

        public Parameter(string name, TType value) : base(name)
        {
            this.name = name;
            this.value = value;
        }

        public TType Value
        {
            get { return value; }
            set { this.value = value; }
        }
    }

    public class ParameterManager
    {
        private Dictionary<string, Parameter> parameters;

        public ParameterManager()
        {
            this.parameters = new Dictionary<string, Parameter>();
        }

        public void AddParameter<TType>(string name, TType value)
        {
            parameters.Add(name, new Parameter<TType>(name, value));
        }

        public TType GetParameter<TType>(string name)
        {
            var parameter = parameters[name] as Parameter<TType>;
            return parameter.Value;
        }

        public void SetParameter<TType>(string name, TType value)
        {
            var parameter = parameters[name] as Parameter<TType>;
            parameter.Value = value;
        }
    }
}