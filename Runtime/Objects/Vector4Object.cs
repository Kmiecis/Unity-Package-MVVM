using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector4Object), fileName = nameof(Vector4Object))]
    public class Vector4Object : DynamicObject<Vector4>
    {
    }
}
