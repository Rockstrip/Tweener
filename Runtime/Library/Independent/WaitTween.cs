namespace Tweener
{
    internal class WaitTween : IndependentTween
    {
        public WaitTween(Tween previous, float duration) : base(previous, duration)
        {
        }

        protected override void SimpleAction()
        {
        }
    }
}