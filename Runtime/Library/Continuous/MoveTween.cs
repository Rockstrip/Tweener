using UnityEngine;

namespace Tweener
{
    internal class MoveTween : ContinuousTween
    {
        private Vector3 destination;
        private Vector3 position;
        
        public MoveTween(Tween previous, Vector3 destination, float duration) : base(previous, duration)
        {
            this.destination = destination;
        }

        protected override void OnStart()
        {
            position = Target.transform.position;
            destination += position;
        }

        protected override void OnUpdate(float time)
        {
            Target.transform.position = Vector3.Lerp(position, destination, time);
        }
    }
}