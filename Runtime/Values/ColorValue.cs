using UnityEngine;

namespace Common.MVVM
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
