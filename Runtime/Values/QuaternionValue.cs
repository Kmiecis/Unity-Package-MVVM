using UnityEngine;

namespace Common.MVB
{
    public sealed class QuaternionValue : DynamicValue<Quaternion>
    {
        public QuaternionValue() :
            base()
        {
        }

        public QuaternionValue(Quaternion value) :
            base(value)
        {
        }
    }
}
