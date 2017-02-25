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

            parameters.AddParameter<string>("name", "unknown");
        }

        public ParameterManager Parameters => parameters;

        protected void AddStandardParameters()
        {
            parameters.AddParameter("translate", new Vector3D(0.0, 0.0, 0.0));
            parameters.AddParameter("scale", new Vector3D(1.0, 1.0, 1.0));
            parameters.AddParameter("rotate", new Vector3D(0.0, 0.0, 0.0));
            parameters.AddParameter("texture", "red");
        }

        public virtual void ExportToJson(JsonTextWriter jsonWriter)
        {
            jsonWriter.WriteStartObject();
            parameters.ExportToJson(jsonWriter);
            jsonWriter.WriteEndObject();
        }
    }
}