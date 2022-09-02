using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(IntObject), fileName = nameof(IntObject))]
    public class IntObject : DynamicObject<int>
    {
    }
}
