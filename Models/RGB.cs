using mse.Models.Parameters;

namespace mse.Models
{
    public class RGB
    {
        protected float _red, _green, _blue;

        public RGB() : this(0.0f, 0.0f, 0.0f)
        {
        }

        public RGB(float red, float green, float blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }
    }

    public class RGBA : RGB
    {
        protected float _alpha;

        public RGBA(float red, float green, float blue, float alpha) : base(red, green, blue)
        {
            _alpha = alpha;
        }

        public RGBA() : this(0.0f, 0.0f, 0.0f, 1.0f)
        {
            
        }
    }
}