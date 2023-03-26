using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector2IntAsset), fileName = nameof(Vector2IntAsset))]
    public sealed class Vector2IntAsset : ScriptableValue<Vector2Int>
    {
    }
}
