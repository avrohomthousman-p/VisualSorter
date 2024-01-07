using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter.SortingLogic
{

    /// <summary>
    /// Implementation of AbstractSorter that uses Shell Sort.
    /// </summary>
    internal class ShellSorter : AbstractSorter
    {

        public ShellSorter() { }


        public ShellSorter(int dataSize) : base(dataSize) { }



        public override IEnumerable<Tuple<int, int>> Sort()
        {

            int gap = data.Length / 2;

            while (gap > 0)
            {
                for (int i = gap; i < data.Length; i++)
                {
                    int temp = data[i];
                    int j = i;

                    while (j >= gap && data[j - gap] > temp)
                    {
                        IStepByStepSorter.Swap(data, j, j - gap);
                        yield return new Tuple<int, int>(j, j - gap);
                        j -= gap;
                    }
                }

                gap /= 2;
            }
        }
    }
}
