using Newtonsoft.Json;

namespace mse.Models.Parameters
{
    public abstract class Parameter
    {
        protected string _name;

        public Parameter(string name)
        {
            _name = name;
        }

        public abstract void ExportToJson(JsonTextWriter jsonWriter);
        public abstract void ImportFromJson(JsonTextReader jsonReader);
    }

    public class Parameter<T> : Parameter
    {
        private ParameterValue<T> _value;

        public Parameter(string name, ParameterValue<T> value) : base(name)
        {
            _name = name;
            _value = value;
        }

        public ParameterValue<T> Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override void ExportToJson(JsonTextWriter jsonWriter)
        {
            jsonWriter.WritePropertyName(_name);
            jsonWriter.WriteValue(_value.ToString());
        }

        public override void ImportFromJson(JsonTextReader jsonReader)
        {
            jsonReader.Read();
            if (jsonReader.TokenType == JsonToken.PropertyName)
                _name = jsonReader.Value.ToString();

            jsonReader.Read();
            if (jsonReader.TokenType == JsonToken.String)
                _value.Parse(jsonReader.Value.ToString());
        }
    }
}
