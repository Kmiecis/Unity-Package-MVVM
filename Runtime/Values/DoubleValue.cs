using System;

namespace Common.MVB
{
    [Serializable]
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
