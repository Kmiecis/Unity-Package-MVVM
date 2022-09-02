using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(KeyCodeObject), fileName = nameof(KeyCodeObject))]
    public class KeyCodeObject : DynamicObject<KeyCode>
    {
    }
}
