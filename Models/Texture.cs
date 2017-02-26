using mse.Models.Parameters;
using Newtonsoft.Json;

namespace mse.Models
{
    public class Texture
    {
        protected ParameterManager _parameters;

        public Texture()
        {
            _parameters = new ParameterManager();

            _parameters.AddParameter("name", new StringValue("untitled"));
            _parameters.AddParameter("colour", new RGBAValue(new RGBA(1.0f, 1.0f, 1.0f, 1.0f)));
        }

        public string Name
        {
            get { return _parameters.GetParameter<string>("name").Value; }
            set { _parameters.SetParameter("name", new StringValue(value)); }
        }

        public virtual void ExportToJson(JsonTextWriter jsonWriter)
        {
            jsonWriter.WriteStartObject();
            _parameters.ExportToJson(jsonWriter);
            jsonWriter.WriteEndObject();
        }
    }
}