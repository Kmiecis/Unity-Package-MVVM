using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector2Object), fileName = nameof(Vector2Object))]
    public sealed class Vector2Object : ScriptableValue<Vector2>
    {
    }
}
