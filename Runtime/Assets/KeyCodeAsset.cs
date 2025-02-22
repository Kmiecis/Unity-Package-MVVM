using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(KeyCodeAsset), fileName = nameof(KeyCodeAsset))]
    public sealed class KeyCodeAsset : ScriptableValue<KeyCode>
    {
        public bool IsDown()
            => Input.GetKeyDown(_value);

        public bool IsHeld()
            => Input.GetKey(_value);

        public bool IsUp()
            => Input.GetKeyUp(_value);
    }
}
