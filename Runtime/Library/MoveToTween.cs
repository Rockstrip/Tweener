using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class MoveToTween : Tween
    {
        private readonly Vector2 point;
        private readonly float duration;
        
        public MoveToTween(Tween previous, Vector2 point, float duration) : base(previous)
        {
            this.point = point;
            this.duration = duration;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            var oldPoint = Target.transform.localPosition;
            
            
            float elapsed = 0f;
            while (elapsed <= duration)
            {
                elapsed += Time.deltaTime;

                Target.transform.localPosition = Vector3.Lerp(oldPoint, point, elapsed / duration);
                
                yield return null;
            }
        }
    }
}