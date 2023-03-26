using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(IntAsset), fileName = nameof(IntAsset))]
    public sealed class IntAsset : ScriptableValue<int>
    {
    }
}
