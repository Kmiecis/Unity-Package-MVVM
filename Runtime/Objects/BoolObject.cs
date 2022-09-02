using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(BoolObject), fileName = nameof(BoolObject))]
    public class BoolObject : DynamicObject<bool>
    {
    }
}
