using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(QuaternionObject), fileName = nameof(QuaternionObject))]
    public sealed class QuaternionObject : ScriptableValue<Quaternion>
    {
        public QuaternionObject()
        {
            _value = Quaternion.identity;
        }
    }
}
