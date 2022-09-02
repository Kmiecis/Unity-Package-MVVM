namespace Common.MVVM
{
    public sealed class FloatValue : DynamicValue<float>
    {
        public FloatValue() :
            base()
        {
        }

        public FloatValue(float value) :
            base(value)
        {
        }
    }
}
