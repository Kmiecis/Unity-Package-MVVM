using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(ScriptableKeyCode), fileName = nameof(ScriptableKeyCode))]
    public sealed class ScriptableKeyCode : ScriptableValue<KeyCode>
    {
    }
}
