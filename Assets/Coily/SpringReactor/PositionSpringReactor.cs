using UnityEngine;

namespace Coily.SpringReactor
{
    public class PositionSpringReactor : BaseSpringReactor
    {
        [SerializeField] private Transform targetTransform;
        [SerializeField] private Transform minTarget;
        [SerializeField] private Transform maxTarget;
        
        protected override void OnSpringUpdate(float position)
        {
            targetTransform.position = Vector3.LerpUnclamped(minTarget.position, maxTarget.position, position);
        }
    }
}