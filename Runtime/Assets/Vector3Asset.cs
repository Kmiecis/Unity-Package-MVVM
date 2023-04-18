using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector3Asset), fileName = nameof(Vector3Asset))]
    public sealed class Vector3Asset : ScriptableValue<Vector3>
    {
    }
}
