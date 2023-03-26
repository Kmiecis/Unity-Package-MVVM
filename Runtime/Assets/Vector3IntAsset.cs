using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector3IntAsset), fileName = nameof(Vector3IntAsset))]
    public sealed class Vector3IntAsset : ScriptableValue<Vector3Int>
    {
    }
}
