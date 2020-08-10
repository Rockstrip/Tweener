using UnityEngine;

namespace Tweener
{
    internal class SetScaleTween : ImmidiateTween
    {
        private readonly Vector2 scale;

        public SetScaleTween(Tween previous, Vector2 scale) : base(previous)
        {
            this.scale = scale;
        }

        protected override void SimpleAction()
        {
            Target.transform.localScale = scale;
        }
    }
}