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



        /// <summary>
        /// Does one partiotion of the quicksort.
        /// </summary>
        /// <param name="start">the start index of the area being sorted</param>
        /// <param name="end">the end index of the area being sorted</param>
        /// <returns>each swap as its being done</returns>
        private IEnumerable<Tuple<int, int>> Partition(int start, int end)
        {
            if(start >= end) //one or zero elements remain
            {
                yield break;
            }
            if(start + 1 == end) //exactly 2 elements remain
            {
                if (data[start] > data[end])
                {
                    IStepByStepSorter.Swap(data, start, end);
                    yield return new Tuple<int, int>(start, end);
                }

                yield break;
            }



            //Choose a pivot
            int pivotIndex = ChoosePivot(start, end);
            int pivotValue = data[pivotIndex];

            //Move the pivot to the end
            IStepByStepSorter.Swap(data, pivotIndex, end);
            yield return new Tuple<int, int>(pivotIndex, end);
            pivotIndex = end;


            //Now start the sort

            int left = start;
            while(left < pivotIndex)
            {
                if (data[left] > pivotValue)
                {
                    IStepByStepSorter.Swap(data, pivotIndex, pivotIndex - 1);
                    yield return new Tuple<int, int>(pivotIndex, pivotIndex - 1);
                    pivotIndex--;


                    if(pivotIndex == left)//corner case: when left and pivot are adjacent, only do one swap
                    {
                        continue;
                    }

                    IStepByStepSorter.Swap(data, left, pivotIndex + 1);
                    yield return new Tuple<int, int>(left, pivotIndex + 1);
                }
                else
                {
                    left++;
                }
            }           



            //TODO: Recursive calls
        }




        /// <summary>
        /// Chooses a good pivot to be used when partioning this part of the array
        /// </summary>
        /// <param name="start">the start index of the area being sorted</param>
        /// <param name="end">the end index of the area being sorted</param>
        /// <returns>a good pivot to use</returns>
        private int ChoosePivot(int start, int end)
        {
            int first = data[data.Length - 1];
            int second = data[data.Length - 2];
            int third = data[data.Length - 3];


            if(IsBetween(first, second, third))
            {
                return data.Length - 1;
            }
            if(IsBetween(second, first, third))
            {
                return data.Length - 2;
            }

            return data.Length - 3;
        }




        /// <summary>
        /// Checks if the target number is between the other two numbers. The first does not need
        /// to be larger than the second number.
        /// </summary>
        /// <param name="target">the number that is being checked</param>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>true if the target is between the other two and false otherwise</returns>
        private bool IsBetween(int target, int first, int second)
        {
            int larger, smaller;
            if(first > second)
            {
                larger = first;
                smaller = second;
            }
            else
            {
                larger = second;
                smaller = first;
            }

            return target >= smaller && target <= larger;
        }
    }
}
