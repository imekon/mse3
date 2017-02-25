namespace mse.Models.Parameters
{
    public class FloatValue : ParameterValue<float>
    {
        public FloatValue(float value) : base(value)
        {

        }

        public override void Parse(string text)
        {
            float.TryParse(text, out _value);
        }
    }
}