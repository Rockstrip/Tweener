namespace Tweener
{
    internal class DisableTween : ImmidiateTween
    {
        public DisableTween(Tween previous) : base(previous)
        {
        }

        protected override void SimpleAction()
        {
            Target.SetActive(false);
        }
    }
}