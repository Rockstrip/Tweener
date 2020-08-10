using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tweener
{
    public class TweenMaster : MonoBehaviour
    {
        public static TweenMaster Common { get; private set; }
        private TweenMaster()
        {
            Common = this;
        }
    }
}