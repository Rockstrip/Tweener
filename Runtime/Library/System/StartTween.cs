using System.Collections;
using UnityEngine;

namespace Tweener
{
    internal class StartTween : Tween
    {
        public StartTween(GameObject target) : base(target)
        {
        }

        public override IEnumerator CreateTask()
        {
            yield return null;
        }
    }
}