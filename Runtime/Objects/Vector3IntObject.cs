using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(Vector3IntObject), fileName = nameof(Vector3IntObject))]
    public sealed class Vector3IntObject : ScriptableValue<Vector3Int>
    {
    }
}
