using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class RotateTween : IndependentTween
    {
        private readonly RectTransform rectComponent;
        private readonly float rotationSpeed;
        
        public RotateTween(Tween previous, float angle, float duration) : base(previous, duration)
        {
            this.rotationSpeed = angle / duration; 
            rectComponent = Target.GetComponent<RectTransform>();
        }

        protected override void SimpleAction()
        {
            rectComponent.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
}