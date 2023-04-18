using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector4Asset), fileName = nameof(Vector4Asset))]
    public sealed class Vector4Asset : ScriptableValue<Vector4>
    {
    }
}
