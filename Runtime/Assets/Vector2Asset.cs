using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector2Asset), fileName = nameof(Vector2Asset))]
    public sealed class Vector2Asset : ScriptableValue<Vector2>
    {
    }
}
