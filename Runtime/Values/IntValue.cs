namespace Common.MVVM
{
    public sealed class IntValue : DynamicValue<int>
    {
        public IntValue() :
            base()
        {
        }

        public IntValue(int value) :
            base(value)
        {
        }
    }
}
