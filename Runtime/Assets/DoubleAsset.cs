using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(DoubleAsset), fileName = nameof(DoubleAsset))]
    public sealed class DoubleAsset : ScriptableValue<double>
    {
    }
}
