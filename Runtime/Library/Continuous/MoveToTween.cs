using UnityEngine;

namespace Tweener
{
    internal class MoveToTween : ContinuousTween
    {
        private readonly Vector3 destination;
        private Vector3 position;
        
        public MoveToTween(Tween previous, Vector3 destination, float duration) : base(previous, duration)
        {
            this.destination = destination;
        }

        protected override void OnStart()
        {
            position = Target.transform.position;
        }

        protected override void OnUpdate(float time)
        {
            Target.transform.position = Vector3.Lerp(position, destination, time);
        }
    }
}