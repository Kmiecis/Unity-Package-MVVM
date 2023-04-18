using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(QuaternionAsset), fileName = nameof(QuaternionAsset))]
    public sealed class QuaternionAsset : ScriptableValue<Quaternion>
    {
        public QuaternionAsset()
        {
            _value = Quaternion.identity;
        }
    }
}
