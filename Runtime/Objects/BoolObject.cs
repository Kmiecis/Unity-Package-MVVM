using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(BoolObject), fileName = nameof(BoolObject))]
    public sealed class BoolObject : ScriptableValue<bool>
    {
    }
}
