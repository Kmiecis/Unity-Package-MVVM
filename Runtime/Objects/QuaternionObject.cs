using UnityEngine;

namespace Common.MVVM
{
    [CreateAssetMenu(menuName = nameof(MVVM) + "/" + nameof(QuaternionObject), fileName = nameof(QuaternionObject))]
    public class QuaternionObject : DynamicObject<Quaternion>
    {
    }
}
