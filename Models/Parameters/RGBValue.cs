namespace mse.Models.Parameters
{
    public class RGBValue : ParameterValue<RGB>
    {
        public RGBValue(RGB value) : base(value)
        {
        }

        public override void Parse(string text)
        {
            var tokens = text.Split(',');

            var r = float.Parse(tokens[0]);
            var g = float.Parse(tokens[1]);
            var b = float.Parse(tokens[2]);

            _value = new RGB(r, g, b);
        }
    }
}