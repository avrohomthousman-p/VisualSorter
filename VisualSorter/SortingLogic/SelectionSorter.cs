using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter.SortingLogic
{

    /// <summary>
    /// Implementation of AbstractSorter that uses Selection Sort.
    /// </summary>
    internal class SelectionSorter : AbstractSorter
    {

        public SelectionSorter() { }

        public SelectionSorter(int dataSize) : base(dataSize) { }



        public override IEnumerable<Tuple<int, int>> Sort()
        {
            for(int i = 0; i < data.Length; i++)
            {
                int minIndex = i;

                for(int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[minIndex])
                    {
                        minIndex = j;
                    }
                }


                IStepByStepSorter.Swap(data, i, minIndex);
                yield return new Tuple<int, int>(i, minIndex);
            }
        }
    }
}
