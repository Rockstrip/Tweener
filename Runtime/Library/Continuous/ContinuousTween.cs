using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal abstract class ContinuousTween : Tween
    {
        private readonly float duration;

        protected ContinuousTween(Tween previous, float duration) : base(previous)
        {
            this.duration = duration;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            
            OnStart();
            var elapsed = 0f;
            do
            {
                elapsed += Time.deltaTime;
                OnUpdate(elapsed / duration);
                yield return null;
            } while (elapsed <= duration);
        }

        protected virtual void OnStart() {}
        protected virtual void OnUpdate(float time) {}
        
    }
}