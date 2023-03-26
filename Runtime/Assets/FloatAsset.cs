using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(FloatAsset), fileName = nameof(FloatAsset))]
    public sealed class FloatAsset : ScriptableValue<float>
    {
    }
}
