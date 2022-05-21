using UnityEngine;

namespace Coily.SpringReactor
{
    public class RotationSpringReactor : BaseSpringReactor
    {
        [SerializeField] private Transform targetTransform;
        [SerializeField] private Vector3 minRotation = new Vector3(0, 0, -90);
        [SerializeField] private Vector3 maxRotation = new Vector3(0, 0, 90);

        protected override void OnSpringUpdate(float position)
        {
            targetTransform.rotation = Quaternion.Euler(Vector3.LerpUnclamped(minRotation, maxRotation, position));
        }
    }
}