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
            if(size <= 0)
            {
                throw new ArgumentOutOfRangeException("Initial size must be greater than zero.");
            }


            data = new int[size];
            FillArray();
        }



        public AbstractSorter(int[] dataToSort)
        {
            this.data = new int[dataToSort.Length];

            this.SetData(dataToSort);
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



        public int[] GetData()
        {
            int[] deepCopy = new int[data.Length];

            Array.Copy(data, deepCopy, data.Length);

            return deepCopy;
        }



        public int GetDataAt(int index)
        {
            if(index < 0 || index >= data.Length)
            {
                throw new IndexOutOfRangeException($"index {index} out of range for array of length {data.Length}.");
            }

            return data[index];
        }



        public void Reset()
        {
            FillArray();
        }



        public void Reset(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("Initial size must be greater than zero.");
            }


            data = new int[size];
            FillArray();
        }



        public void SetData(int[] dataToSort)
        {
            if(dataToSort.Length != this.data.Length)
            {
                this.data = new int[dataToSort.Length];
            }
            
            Array.Copy(dataToSort, this.data, dataToSort.Length);
        }



        public abstract IEnumerable<Tuple<int, int>> Sort();
    }
}
