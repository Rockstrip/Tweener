using UnityEngine;

namespace Tweener
{
    internal class DestroyTween : ImmidiateTween
    {
        public DestroyTween(Tween previous) : base(previous)
        {
        }

        protected override void SimpleAction()
        {
            Object.Destroy(Target);
        }
    }
}