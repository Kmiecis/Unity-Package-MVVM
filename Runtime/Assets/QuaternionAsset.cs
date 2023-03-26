using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(QuaternionAsset), fileName = nameof(QuaternionAsset))]
    public sealed class QuaternionAsset : ScriptableValue<Quaternion>
    {
        public QuaternionAsset()
        {
            _value = Quaternion.identity;
        }
    }
}
