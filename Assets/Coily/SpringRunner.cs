using System;
using UnityEngine;
using UnityEngine.Events;

namespace Coily
{

    /// <summary>
    /// Runs a spring simulation, will update any subscribers on Update with the spring's current value.
    /// </summary>
    public class SpringRunner : MonoBehaviour
    {
        public event Action<float> OnSpringValueChanged = delegate { };

        [SerializeField] private float angularFrequency = 5f;
        [SerializeField] private float dampingRatio = .5f;
        [SerializeField] private UnityEvent<float> OnSpringValueChangedUnityEvent;

        /// <summary>
        /// The current position of the spring.
        /// </summary>
        public float Position => position;

        /// <summary>
        /// The spring's current velocity.
        /// </summary>
        public float Velocity
        {
            get => velocity;
            set => velocity = value;
        }

        /// <summary>
        /// The target position of the spring.
        /// </summary>
        public float Target
        {
            get => equilibriumPosition;
            set => equilibriumPosition = value;
        }

        private float position;
        private float velocity;
        private float equilibriumPosition;

        private void Update()
        {
            DampedSprings.UpdateSpringMotion(ref position,
                ref velocity,
                equilibriumPosition,
                Time.deltaTime,
                angularFrequency,
                dampingRatio);

            OnSpringValueChangedUnityEvent.Invoke(position);
            OnSpringValueChanged(position);
        }
    }
}