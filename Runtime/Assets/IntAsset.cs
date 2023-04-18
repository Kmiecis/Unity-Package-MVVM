using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(IntAsset), fileName = nameof(IntAsset))]
    public sealed class IntAsset : ScriptableValue<int>
    {
    }
}
