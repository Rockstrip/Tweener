using System;
using System.Collections;
using UnityEngine;

namespace Tweener
{
    public abstract partial class Tween
    {
        protected readonly GameObject Target;
        internal readonly Tween Previous;
        
        private protected Tween(Tween previous, GameObject target)
        {
            Previous = previous;
            Target = target;
        }
        protected Tween(Tween previous)
        {
            Previous = previous;
            Target = previous.Target;
        }

        public static Tween CreateFor(GameObject target)
        {
            return new StartTween(null ,target);
        }

        public Tween For(GameObject target)
        {
            return new StartTween(this, target);
        }

        public void Run()
        {
            TweenMaster.Common.StartCoroutine(this.CreateTask());
        }

        

        public abstract IEnumerator CreateTask();
    }
}