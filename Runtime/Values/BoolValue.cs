namespace Common.MVVM
{
    public sealed class BoolValue : DynamicValue<bool>
    {
        public BoolValue() :
            base()
        {
        }

        public BoolValue(bool value) :
            base(value)
        {
        }
    }
}
