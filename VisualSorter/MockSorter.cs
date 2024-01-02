using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter
{
    /// <summary>
    /// Implementation of the Abstract sorter that doesnt actually sort anything, it just sets up
    /// the data.
    /// </summary>
    internal class MockSorter : AbstractSorter
    {
        public override IEnumerable<Tuple<int, int>> Sort()
        {
            yield break;
        }
    }
}
