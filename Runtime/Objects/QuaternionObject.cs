using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(QuaternionObject), fileName = nameof(QuaternionObject))]
    public class QuaternionObject : DynamicObject<Quaternion>
    {
    }
}
