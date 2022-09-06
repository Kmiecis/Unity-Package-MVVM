using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableQuaternion), fileName = nameof(ScriptableQuaternion))]
    public sealed class ScriptableQuaternion : ScriptableValue<Quaternion>
    {
        public ScriptableQuaternion()
        {
            _value = Quaternion.identity;
        }
    }
}
