using UnityEngine;

namespace Common.MVB
{
    [CreateAssetMenu(menuName = nameof(MVB) + "/" + nameof(IntObject), fileName = nameof(IntObject))]
    public class IntObject : DynamicObject<int>
    {
    }
}
