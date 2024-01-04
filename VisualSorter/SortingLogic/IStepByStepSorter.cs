using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter.SortingLogic
{
    /// <summary>
    /// Sorts an array of integers one step at a time, returning each swap as it is done.
    /// </summary>
    public interface IStepByStepSorter
    {

        /// <summary>
        /// Resets the data so it can be sorted again.
        /// 
        /// The number of elements being sorted does not change.
        /// </summary>
        public void Reset();



        /// <summary>
        /// Resets the data so it can be sorted again. The number of elements being sorted
        /// will be set to the specified size.
        /// </summary>
        /// <param name="size">the number of elements that should be sorted</param>
        public void Reset(int size);



        /// <summary>
        /// Gets the full array that is being sorted.
        /// </summary>
        /// <returns>a deep copy of the data being sorted</returns>
        public int[] GetData();



        /// <summary>
        /// Gets the number of elements being sorted
        /// </summary>
        /// <returns>the number of elements being sorted</returns>
        public int DataSize();



        /// <summary>
        /// Sets the array that will be sorted.
        /// </summary>
        /// <param name="data">the array that will be sorted</param>
        public void SetData(int[] dataToUse);



        /// <summary>
        /// Gets the data from a specific index of the array being sorted.
        /// </summary>
        /// <param name="index">the position of the data needed</param>
        /// <returns>the data at the position specified</returns>
        public int GetDataAt(int index);



        /// <summary>
        /// Executes the sort
        /// </summary>
        /// <returns>
        /// the two indexes that are swapped at each step of the sort, or a null if the animation
        /// should give an extra pause.
        /// </returns>
        public IEnumerable<Tuple<int, int>> Sort();



        /// <summary>
        /// Swaps the position of two elements in an array
        /// </summary>
        /// <param name="data">the array</param>
        /// <param name="index1">the first index</param>
        /// <param name="index2">the second index</param>
        public static void Swap(int[] data, int index1, int index2)
        {
            int temp = data[index1];
            data[index1] = data[index2];
            data[index2] = temp;
        }
    }
}
