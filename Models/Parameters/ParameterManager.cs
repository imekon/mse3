using System.Collections.Generic;
using Newtonsoft.Json;

namespace mse.Models.Parameters
{
    public class ParameterManager
    {
        private Dictionary<string, Parameter> _parameters;

        public ParameterManager()
        {
            _parameters = new Dictionary<string, Parameter>();
        }

        public void AddParameter<TType>(string name, TType value) where TType : ParameterValue<TType>
        {
            _parameters.Add(name, new Parameter<TType>(name, value));
        }

        public TType GetParameter<TType>(string name) where TType : ParameterValue<TType>
        {
            var parameter = _parameters[name] as Parameter<TType>;
            return parameter.Value;
        }

        public void SetParameter<TType>(string name, TType value) where TType : ParameterValue<TType>
        {
            var parameter = _parameters[name] as Parameter<TType>;
            parameter.Value = value;
        }

        public void ExportToJson(JsonTextWriter jsonWriter)
        {
            foreach (var kvp in _parameters)
            {
                kvp.Value.ExportToJson(jsonWriter);
            }
        }
    }
}