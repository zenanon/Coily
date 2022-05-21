using System;
using UnityEngine;

namespace Coily.SpringReactor
{
    /// <summary>
    /// Base class for monobehaviours that react to spring values provided by a SpringRunner.
    /// </summary>
    public abstract class BaseSpringReactor : MonoBehaviour
    {
        [SerializeField] protected SpringRunner springRunner;

        private void OnEnable()
        {
            springRunner.OnSpringValueChanged += OnSpringUpdate;
            OnSpringUpdate(springRunner.Position);
        }

        private void OnDisable()
        {
            springRunner.OnSpringValueChanged -= OnSpringUpdate;
        }

        /// <summary>
        /// Invoked when the spring updates, implementing classes should use this to react to the spring's value.
        /// </summary>
        protected abstract void OnSpringUpdate(float position);
    }
}