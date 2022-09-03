using System;

namespace Common.MVB
{
    [Serializable]
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
