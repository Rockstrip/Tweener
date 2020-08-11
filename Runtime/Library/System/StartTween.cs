using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class StartTween : Tween
    {
        public StartTween(Tween previous, GameObject target) : base(previous, target)
        {
        }

        public override IEnumerator CreateTask()
        {
            yield return null;
        }
    }
}