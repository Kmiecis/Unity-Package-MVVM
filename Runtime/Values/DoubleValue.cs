namespace Common.MVVM
{
    public sealed class DoubleValue : DynamicValue<double>
    {
        public DoubleValue() :
            base()
        {
        }

        public DoubleValue(double value) :
            base(value)
        {
        }
    }
}
