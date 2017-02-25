using System.Windows.Media.Media3D;

namespace mse.Models.Parameters
{
    public class VectorValue : ParameterValue<Vector3D>
    {
        public VectorValue(Vector3D value) : base(value)
        {

        }

        public override void Parse(string text)
        {
            float x, y, z;

            var tokens = text.Split(',');

            float.TryParse(tokens[0], out x);
            float.TryParse(tokens[1], out y);
            float.TryParse(tokens[2], out z);

            _value = new Vector3D(x, y, z);
        }
    }
}