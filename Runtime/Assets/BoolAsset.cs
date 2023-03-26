using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(BoolAsset), fileName = nameof(BoolAsset))]
    public sealed class BoolAsset : ScriptableValue<bool>
    {
    }
}
