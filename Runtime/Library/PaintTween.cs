using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Tweener
{
    internal class PaintTween : Tween
    {
        private readonly Image imageComponent;
        private readonly float duration;
        private readonly Color color;
        
        public PaintTween(Tween previous, Color color, float duration) : base(previous)
        {
            this.color = color;
            this.duration = duration;
            this.imageComponent = Target.GetComponent<Image>();
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            var oldColor = imageComponent.color;
            
            
            float elapsed = 0f;
            while (elapsed <= duration)
            {
                elapsed += Time.deltaTime;

                imageComponent.color = Color.Lerp(oldColor, color, elapsed / duration);
                
                yield return null;
            }
        }
    }
}