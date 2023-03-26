using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector2Asset), fileName = nameof(Vector2Asset))]
    public sealed class Vector2Asset : ScriptableValue<Vector2>
    {
    }
}
