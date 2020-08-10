using UnityEngine;

namespace Tweener
{
    internal class SetPositionTween : ImmidiateTween
    {
        private readonly Vector2 position;
        
        public SetPositionTween(Tween previous, Vector2 position) : base(previous)
        {
            this.position = position;
        }

        protected override void SimpleAction()
        {
            Target.transform.localPosition = position;
        }
    }
}