using UnityEngine;

namespace Coily
{
    public class SpringBumper : MonoBehaviour
    {
        [SerializeField] private SpringRunner springRunner;

        [SerializeField] private float bumpNegativeAmount;
        [SerializeField] private float bumpPositiveAmount;

        public void BumpNegative()
        {
            springRunner.Velocity += bumpNegativeAmount;
        }

        public void BumpPositive()
        {
            springRunner.Velocity += bumpPositiveAmount;
        }
    }
}