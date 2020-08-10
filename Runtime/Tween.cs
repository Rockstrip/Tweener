using System;
using System.Collections;
using UnityEngine;

namespace Tweener
{
    public abstract partial class Tween
    {
        protected readonly GameObject Target;
        internal readonly Tween Previous;
        
        private protected Tween(GameObject target)
        {
            Previous = null;
            Target = target;
        }
        protected Tween(Tween previous)
        {
            Previous = previous;
            Target = previous.Target;
        }

        public static Tween Create(GameObject target)
        {
            return new StartTween(target);
        }
        
        
        public void Run()
        {
            TweenMaster.Common.StartCoroutine(this.CreateTask());
        }

        

        public abstract IEnumerator CreateTask();
    }
}