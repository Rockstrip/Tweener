using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class RotateToTween : Tween
    {
        private readonly float angle;
        private readonly float duration;
        
        public RotateToTween(Tween previous, float angle, float duration) : base(previous)
        {
            this.angle = angle;
            this.duration = duration;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            var oldAngle = Target.transform.localRotation.eulerAngles.z;
            
            float elapsed = 0f;
            while (elapsed <= duration)
            {
                elapsed += Time.deltaTime;

                var newAngle = Mathf.Lerp(oldAngle, angle, elapsed / duration); 
                Target.transform.rotation = Quaternion.Euler(0,0, newAngle);
                
                yield return null;
            }
        }
    }
}