using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(KeyCodeAsset), fileName = nameof(KeyCodeAsset))]
    public sealed class KeyCodeAsset : ScriptableValue<KeyCode>
    {
    }
}
