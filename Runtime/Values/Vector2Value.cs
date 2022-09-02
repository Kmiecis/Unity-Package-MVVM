using UnityEngine;

namespace Common.MVVM
{
    public sealed class Vector2Value : DynamicValue<Vector2>
    {
        public Vector2Value() :
            base()
        {
        }

        public Vector2Value(Vector2 value) :
            base(value)
        {
        }
    }
}