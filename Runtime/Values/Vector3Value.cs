using UnityEngine;

namespace Common.MVB
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
