using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter
{
    /// <summary>
    /// Sorts an array of integers one step at a time, returning each swap as it is done.
    /// </summary>
    public interface IStepByStepSorter
    {

        /// <summary>
        /// Executes the sort
        /// </summary>
        /// <returns>the two indexes that are swapped at each step of the sort</returns>
        public IEnumerable<Tuple<int, int>> Sort();

    }
}
