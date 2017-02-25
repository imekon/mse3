namespace mse.Models.Parameters
{
    public abstract class ParameterValue<TType>
    {
        protected TType _value;

        public ParameterValue(TType value)
        {
            _value = value;
        }

        public TType Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public abstract void Parse(string text);
    }
}