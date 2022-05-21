using System;
using UnityEngine;

namespace Coily
{
    public class SpringTargetController : MonoBehaviour
    {
        [SerializeField] private SpringRunner springRunner;

        [SerializeField] private float[] targetValues;

        [SerializeField] private int initialIndex;


        public void SetTargetIndex(float index)
        {
            SetTargetIndex(Mathf.RoundToInt(index));
        }
        
        public void SetTargetIndex(int index)
        {
            if (index < 0 || index >= targetValues.Length)
            {
                throw new IndexOutOfRangeException(
                    $"Index {index} out of range for SpringTargetController with {targetValues.Length} indexes.");
            }
            
            springRunner.Target = targetValues[index];
        }
    }
}