using UnityEngine;

namespace Common.MVB
{
    public sealed class ColorValue : DynamicValue<Color>
    {
        public ColorValue() :
            base()
        {
        }

        public ColorValue(Color value) :
            base(value)
        {
        }
    }
}
