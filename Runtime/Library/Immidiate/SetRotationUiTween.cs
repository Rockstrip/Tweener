using UnityEngine;

namespace Tweener
{
    internal class SetRotationUiTween : ImmidiateTween
    {
        private readonly float angle;

        public SetRotationUiTween(Tween previous, float angle) : base(previous)
        {
            this.angle = angle;
        }

        protected override void SimpleAction()
        {
            Target.transform.localRotation = Quaternion.Euler(1,1, angle);
        }
    }
}