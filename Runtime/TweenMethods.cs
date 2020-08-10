using UnityEngine;

namespace Tweener
{
    public abstract partial class Tween
    {
        public Tween Enable()
        {
            return new EnableTween(this);
        }
        public Tween Disable()
        {
            return new DisableTween(this);
        }
        public Tween Destroy()
        {
            return new DestroyTween(this);
        }

        public Tween SetColor(Color color)
        {
            return new SetColorTween(this, color);
        }
        public Tween SetPosition(Vector2 point)
        {
            return new SetPositionTween(this, point);
        }
        public Tween SetRotation(float angle)
        {
            return new SetRotationTween(this, angle);
        }
        public Tween SetScale(Vector2 scale)
        {
            return new SetScaleTween(this, scale);
        }

        public Tween MoveTo(Vector2 point, float duration)
        {
            return  new MoveToTween(this, point, duration);
        }
        public Tween ScaleTo(Vector2 scale, float duration)
        {
            return  new ScaleToTween(this, scale, duration);
        }
        public Tween RotateTo(float angle, float duration)
        {
            return  new RotateToTween(this, angle, duration);
        }
        
        public Tween Wait(float duration)
        {
            return new WaitTween(this, duration);
        }
        
        public Tween Fade(float duration)
        {
            return  new FadeTween(this, duration);
        }
        public Tween Rotate(float angle, float duration)
        {
            return new RotateTween(this, angle, duration);
        }
        public Tween Move(Vector2 localPoint, float duration)
        {
            return new MoveTween(this, localPoint, duration);
        }
        public Tween Paint(Color color, float duration)
        {
            return  new PaintTween(this, color, duration);
        }
        public Tween Parallel(params Tween[] threads)
        {
            return new ParallelTween(this, threads);
        }
        
    }
}