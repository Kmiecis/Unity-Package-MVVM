using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(StringObject), fileName = nameof(StringObject))]
    public class StringObject : DynamicObject<string>
    {
    }
}
