using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector2IntAsset), fileName = nameof(Vector2IntAsset))]
    public sealed class Vector2IntAsset : ScriptableValue<Vector2Int>
    {
    }
}
