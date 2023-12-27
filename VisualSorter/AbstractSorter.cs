using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualSorter
{
    /// <summary>
    /// Implementation of all methods in the IStepByStepSorter interface other than the actual sorting method.
    /// This serves to manage all the implementation details related to the data being sorted.
    /// </summary>
    public abstract class AbstractSorter : IStepByStepSorter
    {
        protected static Random generator = new Random();
        protected static readonly int DEFAULT_SIZE = 10;
        private int[] data;


        public AbstractSorter()
        {
            data = new int[DEFAULT_SIZE];
            FillArray();
        }



        public AbstractSorter(int size)
        {
            data = new int[size];
            FillArray();
        }



        public AbstractSorter(int[] dataToSort)
        {
            data = new int[dataToSort.Length];
            Array.Copy(dataToSort, data, dataToSort.Length);
        }



        /// <summary>
        /// Fills the data array with random numbers from 1 to 99 inclusive.
        /// </summary>
        protected void FillArray()
        {
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = generator.Next(1, 100);
            }
        }



        public abstract int[] GetData();



        public abstract int GetDataAt(int index);



        public abstract void Reset(int size = 10);



        public abstract void SetData(int[] data);



        public abstract IEnumerable<Tuple<int, int>> Sort();
    }
}
