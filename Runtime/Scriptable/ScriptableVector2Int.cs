using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableVector2Int), fileName = nameof(ScriptableVector2Int))]
    public sealed class ScriptableVector2Int : ScriptableValue<Vector2Int>
    {
    }
}
