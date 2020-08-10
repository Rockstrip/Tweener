using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Tweener
{
    internal class SetColorTween : ImmidiateTween
    {
        private readonly Color color;
        private readonly Image image;
        private readonly TextMeshProUGUI text;
        
        public SetColorTween(Tween previous, Color color) : base(previous)
        {
            this.color = color;
            
            if(Target.TryGetComponent(out Image i)) image = i;
            
            if(Target.TryGetComponent(out TextMeshProUGUI t)) text = t;
            
        }

        protected override void SimpleAction()
        {
            if (text != null) text.color = color;
            if (image != null) image.color = color;
        }
    }
}