using UnityEngine;
using UnityEngine.UI;

namespace Coily.SpringReactor
{
    public class ColorSpringReactor : BaseSpringReactor
    {
        [SerializeField] private Image targetImage;
        [SerializeField] private Color minColor = Color.black;
        [SerializeField] private Color maxColor = Color.white;

        protected override void OnSpringUpdate(float position)
        {
            targetImage.color = Color.LerpUnclamped(minColor, maxColor, position);
        }
    }
}