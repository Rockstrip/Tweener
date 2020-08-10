using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Tweener
{
    internal class FadeTween : Tween
    {
        private readonly float duration;
        private readonly List<Image> images;
        private readonly List<TextMeshProUGUI> labels;
        
        public FadeTween(Tween previous, float duration) : base(previous)
        {
            this.duration = duration;
            
            images = Target.GetComponentsInChildren(typeof(Image)).Cast<Image>().ToList();
            if(Target.TryGetComponent(out Image image)) images.Add(image);
            
            labels = Target.GetComponentsInChildren(typeof(TextMeshProUGUI)).Cast<TextMeshProUGUI>().ToList();
            if(Target.TryGetComponent(out TextMeshProUGUI text)) labels.Add(text);
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();

            var imagePairs = images.Select(element => (element, element.color)).ToArray(); 
            var textPairs = labels.Select(element => (element, element.color)).ToArray(); 
            
            float elapsed = 0f;
            while (elapsed <= duration)
            {
                elapsed += Time.deltaTime;
                
                foreach (var pair in imagePairs) 
                    pair.element.color = Color.Lerp(pair.color, Color.clear, elapsed / duration);

                foreach (var pair in textPairs) 
                    pair.element.color = Color.Lerp(pair.color, Color.clear, elapsed / duration);
                
                yield return null;
            }
        }
    }
}