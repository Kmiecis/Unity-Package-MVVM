using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableVector3Int), fileName = nameof(ScriptableVector3Int))]
    public sealed class ScriptableVector3Int : ScriptableValue<Vector3Int>
    {
    }
}
