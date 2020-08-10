using System.Collections;
using System.Linq;

namespace Tweener
{
    class ParallelTween : Tween
    {
        private Tween[] threads;
        
        public ParallelTween(Tween previous, Tween[] threads) : base(previous)
        {
            this.threads = threads;
        }

        public override IEnumerator CreateTask()
        {
            yield return Previous.CreateTask();

            var enumerators = threads.Select(t => t.CreateTask()).ToArray();
            
            bool anyRunning;
            do
            {
                anyRunning = false;
                
                foreach (var item in enumerators)
                {
                    if (item.MoveNext())
                        anyRunning = true;
                }
                yield return null;

            } while (anyRunning);
        }
    }
}