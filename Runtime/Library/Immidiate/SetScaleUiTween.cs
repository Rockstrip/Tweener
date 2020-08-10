using UnityEngine;

namespace Tweener
{
    internal class SetScaleUiTween : ImmidiateTween
    {
        private readonly Vector2 scale;

        public SetScaleUiTween(Tween previous, Vector2 scale) : base(previous)
        {
            this.scale = scale;
        }

        protected override void SimpleAction()
        {
            Target.transform.localScale = scale;
        }
    }
}