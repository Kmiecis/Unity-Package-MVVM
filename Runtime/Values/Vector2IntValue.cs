using UnityEngine;

namespace Common.MVVM
{
    public sealed class Vector2IntValue : DynamicValue<Vector2Int>
    {
        public Vector2IntValue() :
            base()
        {
        }

        public Vector2IntValue(Vector2Int value) :
            base(value)
        {
        }
    }
}