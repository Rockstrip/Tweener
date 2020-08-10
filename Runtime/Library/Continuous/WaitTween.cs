namespace Tweener
{
    internal class WaitTween : ContinuousTween
    {
        public WaitTween(Tween previous, float duration) : base(previous, duration)
        {
        }
    }
}