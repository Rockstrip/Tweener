using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class ScaleToTween : Tween
    {
        private readonly Vector2 scale;
        private readonly float duration;
        
        public ScaleToTween(Tween previous, Vector2 scale, float duration) : base(previous)
        {
            this.scale = scale;
            this.duration = duration;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            var oldScale = Target.transform.localScale;
            
            
            float elapsed = 0f;
            while (elapsed <= duration)
            {
                elapsed += Time.deltaTime;

                Target.transform.localScale = Vector3.Lerp(oldScale, scale, elapsed / duration);
                
                yield return null;
            }
        }
    }
}