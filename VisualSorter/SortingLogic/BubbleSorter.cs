using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter.SortingLogic
{
    /// <summary>
    /// Implementation of AbstractSorter that uses Bubble Sort.
    /// </summary>
    internal class BubbleSorter : AbstractSorter
    {

        public BubbleSorter() { }


        public BubbleSorter(int dataSize) : base(dataSize) { }



        public override IEnumerable<Tuple<int, int>> Sort()
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                bool swappedSomething = false;

                for(int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        swappedSomething = true;
                        IStepByStepSorter.Swap(data, j, j + 1);
                        yield return new Tuple<int, int>(j, j + 1);
                    }
                }


                if (!swappedSomething)
                {
                    yield break;
                }
            }
        }
    }
}
