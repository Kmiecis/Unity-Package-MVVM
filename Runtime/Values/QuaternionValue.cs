using UnityEngine;

namespace Common.MVVM
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
