using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal abstract class IndependentTween : Tween
    {
        protected readonly float Duration;
        
        protected IndependentTween(Tween previous, float duration) : base(previous)
        {
            this.Duration = duration;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            
            float elapsed = 0f;
            while (elapsed <= Duration)
            {
                elapsed += Time.deltaTime;
                
                SimpleAction();
                
                yield return null;
            }
        }

        protected abstract void SimpleAction();
    }
}