using System;
using UnityEngine;

namespace Tweener
{
    public abstract partial class Tween
    {
        #region Immidiate
    
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

        public Tween SetColorUi(Color color)
        {
            return new SetColorUiTween(this, color);
        }
        public Tween SetPositionUi(Vector2 point)
        {
            return new SetPositionUiTween(this, point);
        }
        public Tween SetRotationUi(float angle)
        {
            return new SetRotationUiTween(this, angle);
        }
        public Tween SetScaleUi(Vector2 scale)
        {
            return new SetScaleUiTween(this, scale);
        }
        
        #endregion

        #region Continuous

        public Tween MoveTo(Vector3 point, float duration)
        {
            return new MoveToTween(this, point, duration);
        }

        public Tween MoveTween(Vector3 localPoint, float duration)
        {
            return new MoveTween(this, localPoint, duration);
        }
        
        public Tween Wait(float duration)
        {
            return new WaitTween(this, duration);
        }

        #endregion

        #region System

        public Tween Parallel(params Tween[] threads)
        {
            return new ParallelTween(this, threads);
        }

        public Tween Execute(Action<GameObject> action)
        {
            return  new ExecuteTween(this, action);
        }

        #endregion
        
    }
}