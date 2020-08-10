using System.Collections;

namespace Tweener
{
    internal class NextTween : Tween
    {
        private readonly Tween next;

        public NextTween(Tween previous, Tween next) : base(previous)
        {
            this.next = next;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();
            yield return next.CreateTask();
        }
    }
}