using System.Windows.Media.Media3D;
using mse.Models.Parameters;
using Newtonsoft.Json;

namespace mse.Models
{
    public class Shape
    {
        protected ParameterManager _parameters;

        public Shape()
        {
            _parameters = new ParameterManager();

            _parameters.AddParameter<string>("name", new StringValue("unknown"));
        }

        public ParameterManager Parameters => _parameters;

        public string Name
        {
            get { return _parameters.GetParameter<string>("name").Value; }
            set { _parameters.SetParameter("name", new StringValue(value)); }
        }

        protected void AddStandardParameters()
        {
            var texture = TextureManager.GetInstance().FindTexture("Red");

            _parameters.AddParameter("translate", new VectorValue(new Vector3D(0.0, 0.0, 0.0)));
            _parameters.AddParameter("scale", new VectorValue(new Vector3D(1.0, 1.0, 1.0)));
            _parameters.AddParameter("rotate", new VectorValue(new Vector3D(0.0, 0.0, 0.0)));
            _parameters.AddParameter("texture", new TextureValue(texture));
        }

        public virtual void ExportToJson(JsonTextWriter jsonWriter)
        {
            jsonWriter.WriteStartObject();
            _parameters.ExportToJson(jsonWriter);
            jsonWriter.WriteEndObject();
        }
    }
}