using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter.SortingLogic
{

    /// <summary>
    /// Implementation of AbstractSorter that uses Quick Sort.
    /// </summary>
    internal class QuickSorter : AbstractSorter
    {
        public QuickSorter() { }

        public QuickSorter(int dataSize) : base(dataSize) { }



        public override IEnumerable<Tuple<int, int>> Sort()
        {
            throw new NotImplementedException();
        }
    }
}
