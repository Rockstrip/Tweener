using UnityEngine;

namespace Tweener
{
    internal class SetRotationTween : ImmidiateTween
    {
        private readonly float angle;

        public SetRotationTween(Tween previous, float angle) : base(previous)
        {
            this.angle = angle;
        }

        protected override void SimpleAction()
        {
            Target.transform.localRotation = Quaternion.Euler(1,1, angle);
        }
    }
}