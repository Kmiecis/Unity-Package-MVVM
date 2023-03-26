using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(KeyCodeAsset), fileName = nameof(KeyCodeAsset))]
    public sealed class KeyCodeAsset : ScriptableValue<KeyCode>
    {
    }
}
