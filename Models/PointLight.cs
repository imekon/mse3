using System.Windows.Media.Media3D;
using mse.Models.Parameters;

namespace mse.Models
{
    public class PointLight : Shape
    {
        public PointLight()
        {
            parameters.AddParameter("position", new VectorValue(new Vector3D(2.0, 2.0, 2.0)));
            parameters.AddParameter("colour", new RGBValue(new RGB(1.0f, 1.0f, 1.0f)));
        }
    }
}