using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector2Object), fileName = nameof(Vector2Object))]
    public class Vector2Object : DynamicObject<Vector2>
    {
    }
}
