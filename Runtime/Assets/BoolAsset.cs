using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(BoolAsset), fileName = nameof(BoolAsset))]
    public sealed class BoolAsset : ScriptableValue<bool>
    {
    }
}
