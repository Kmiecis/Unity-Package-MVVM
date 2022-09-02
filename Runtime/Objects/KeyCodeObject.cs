using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(KeyCodeObject), fileName = nameof(KeyCodeObject))]
    public class KeyCodeObject : DynamicObject<KeyCode>
    {
    }
}
