namespace Tweener
{
    internal class EnableTween : ImmidiateTween
    {
        public EnableTween(Tween previous) : base(previous)
        {
        }

        protected override void SimpleAction()
        {
            Target.SetActive(true);
        }
    }
}