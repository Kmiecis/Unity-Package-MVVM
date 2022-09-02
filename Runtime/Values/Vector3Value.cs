using UnityEngine;

namespace Common.MVVM
{
    public sealed class Vector3Value : DynamicValue<Vector3>
    {
        public Vector3Value() :
            base()
        {
        }

        public Vector3Value(Vector3 value) :
            base(value)
        {
        }
    }
}
