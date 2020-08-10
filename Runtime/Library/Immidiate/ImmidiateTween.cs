using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tweener
{
    public abstract class ImmidiateTween : Tween
    {
        protected ImmidiateTween(Tween previous) : base(previous)
        {
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            SimpleAction();
        }

        protected abstract void SimpleAction();
    }
}