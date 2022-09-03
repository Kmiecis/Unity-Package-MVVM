using System;
using UnityEngine;

namespace Common.MVB
{
    [Serializable]
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
