using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class MoveTween : IndependentTween
    {
        private readonly Vector2 speed;
        private readonly RectTransform rectComponent;
        
        public MoveTween(Tween previous, Vector2 localPoint, float duration) : base(previous, duration)
        {
            this.speed = localPoint / duration;
            this.rectComponent = Target.GetComponent<RectTransform>();
        }
        
        protected override void SimpleAction()
        {
            rectComponent.anchoredPosition += speed * Time.deltaTime;
        }
    }
}