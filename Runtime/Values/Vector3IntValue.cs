using UnityEngine;

namespace Common.MVVM
{
    public sealed class Vector3IntValue : DynamicValue<Vector3Int>
    {
        public Vector3IntValue() :
            base()
        {
        }

        public Vector3IntValue(Vector3Int value) :
            base(value)
        {
        }
    }
}