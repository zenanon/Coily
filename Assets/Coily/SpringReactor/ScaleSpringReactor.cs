using UnityEngine;

namespace Coily.SpringReactor
{
    public class ScaleSpringReactor : BaseSpringReactor
    {
        [SerializeField] private Transform targetTransform = default;

        [SerializeField] private Vector3 minScale = Vector3.zero;
        [SerializeField] private Vector3 maxScale = Vector3.one;
        
        protected override void OnSpringUpdate(float position)
        {
            targetTransform.localScale = Vector3.LerpUnclamped(minScale, maxScale, position);
        }
    }
}