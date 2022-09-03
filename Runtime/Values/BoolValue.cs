using System;

namespace Common.MVB
{
    [Serializable]
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
