using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(FloatAsset), fileName = nameof(FloatAsset))]
    public sealed class FloatAsset : ScriptableValue<float>
    {
    }
}
