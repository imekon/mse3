using System.Windows.Media.Media3D;
using mse.Models.Parameters;
using Newtonsoft.Json;

namespace mse.Models
{
    public class Shape
    {
        protected ParameterManager parameters;

        public Shape()
        {
            parameters = new ParameterManager();

            parameters.AddParameter<string>("name", new StringValue("unknown"));
        }

        public ParameterManager Parameters => parameters;

        protected void AddStandardParameters()
        {
            var texture = TextureManager.GetInstance().FindTexture("Red");

            parameters.AddParameter("translate", new VectorValue(new Vector3D(0.0, 0.0, 0.0)));
            parameters.AddParameter("scale", new VectorValue(new Vector3D(1.0, 1.0, 1.0)));
            parameters.AddParameter("rotate", new VectorValue(new Vector3D(0.0, 0.0, 0.0)));
            parameters.AddParameter("texture", new TextureValue(texture));
        }

        public virtual void ExportToJson(JsonTextWriter jsonWriter)
        {
            jsonWriter.WriteStartObject();
            parameters.ExportToJson(jsonWriter);
            jsonWriter.WriteEndObject();
        }
    }
}