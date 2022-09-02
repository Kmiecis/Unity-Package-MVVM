namespace Common.MVVM
{
    public sealed class StringValue : DynamicValue<string>
    {
        public StringValue() :
            base()
        {
        }

        public StringValue(string value) :
            base(value)
        {
        }
    }
}
