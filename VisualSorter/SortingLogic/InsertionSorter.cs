using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter.SortingLogic
{

    /// <summary>
    /// Implementation of AbstractSorter that uses Insertion Sort.
    /// </summary>
    internal class InsertionSorter : AbstractSorter
    {

        public InsertionSorter() { }

        public InsertionSorter(int dataSize) : base(dataSize) { }



        public override IEnumerable<Tuple<int, int>> Sort()
        {
            for(int i = 0; i < data.Length; i++)
            {
                int key = data[i];

                for(int j = i - 1; j >= 0; j--)
                {
                    if (data[j] > key)
                    {
                        IStepByStepSorter.Swap(data, j, j + 1);
                        yield return new Tuple<int, int>(j, j + 1);
                    }
                    else
                    {
                        yield return null;
                        break;
                    }
                }
            }
        }
    }
}
