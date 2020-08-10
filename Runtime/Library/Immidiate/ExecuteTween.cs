using System;
using UnityEngine;

namespace Tweener
{
    internal class ExecuteTween : ImmidiateTween
    {
        private readonly Action<GameObject> action;

        public ExecuteTween(Tween previous, Action<GameObject> action) : base(previous)
        {
            this.action = action;
        }

        protected override void SimpleAction()
        {
            action.Invoke(Target);
        }
    }
}