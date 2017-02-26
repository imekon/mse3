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

        public void AddParameter<T>(string name, ParameterValue<T> value)
        {
            _parameters.Add(name, new Parameter<T>(name, value));
        }

        public ParameterValue<T> GetParameter<T>(string name)
        {
            var parameter = _parameters[name] as Parameter<T>;
            return parameter.Value;
        }

        public void SetParameter<T>(string name, ParameterValue<T> value)
        {
            var parameter = _parameters[name] as Parameter<T>;
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