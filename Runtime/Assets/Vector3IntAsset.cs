using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(Vector3IntAsset), fileName = nameof(Vector3IntAsset))]
    public sealed class Vector3IntAsset : ScriptableValue<Vector3Int>
    {
    }
}
