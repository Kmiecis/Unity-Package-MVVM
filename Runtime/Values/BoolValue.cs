namespace Common.MVB
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
