using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(DoubleAsset), fileName = nameof(DoubleAsset))]
    public sealed class DoubleAsset : ScriptableValue<double>
    {
    }
}
