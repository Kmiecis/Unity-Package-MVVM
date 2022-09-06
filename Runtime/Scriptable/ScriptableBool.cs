using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableBool), fileName = nameof(ScriptableBool))]
    public sealed class ScriptableBool : ScriptableValue<bool>
    {
    }
}
