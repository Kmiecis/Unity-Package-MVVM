using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableVector2), fileName = nameof(ScriptableVector2))]
    public sealed class ScriptableVector2 : ScriptableValue<Vector2>
    {
    }
}
