namespace mse.Models.Parameters
{
    public class StringValue : ParameterValue<string>
    {
        public StringValue(string value) : base(value)
        {

        }

        public override void Parse(string text)
        {
            _value = text;
        }
    }
}