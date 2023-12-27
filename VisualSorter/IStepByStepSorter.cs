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
        /// Resets the data so it can be sorted again.
        /// </summary>
        /// <param name="size">the number of elements that should be sorted</param>
        public void Reset(int size = 10);



        /// <summary>
        /// Gets the full array that is being sorted.
        /// </summary>
        /// <returns></returns>
        public int[] GetData();



        /// <summary>
        /// Sets the array that will be sorted.
        /// </summary>
        /// <param name="data">the array that will be sorted</param>
        public void SetData(int[] data);



        /// <summary>
        /// Gets the data from a specific index of the array being sorted.
        /// </summary>
        /// <param name="index">the position of the data needed</param>
        /// <returns>the data at the position specified</returns>
        public int GetDataAt(int index);



        /// <summary>
        /// Executes the sort
        /// </summary>
        /// <returns>the two indexes that are swapped at each step of the sort</returns>
        public IEnumerable<Tuple<int, int>> Sort();

    }
}
