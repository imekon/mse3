namespace mse.Models.Parameters
{
    public abstract class ParameterValue<T>
    {
        protected T _value;

        public ParameterValue(T value)
        {
            _value = value;
        }

        public T Value
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