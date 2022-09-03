using System;
using UnityEngine;

namespace Common.MVB
{
    [Serializable]
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
