using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// this BubbleSort Class implements bubble sort to sort integer element in ascending order.
    /// the first pass of bubble sort gives the maximum element.
    /// </summary>
    class BubbleSort
    {
        /// <summary>
        /// BubbleSortMethod takes user input for length of required array and and also array elements 
        /// it calls DoBubbleSort method to sort the given array and then displays the sorted array
        /// </summary>
        public void BubbleSortMethod()
        {
            Console.WriteLine(" enter the size of array");
            int len = Utility.Util.ReadInt();

            int[] array = new int[len];
            Console.WriteLine("enter the data in array ");
            Utility.Util.InputIntArray(array);

            Console.Write("entered array is : ");
            Utility.Util.PrintArray(array);

            DoBubbleSort(array);

            Console.Write("sorted array is : ");
            Utility.Util.PrintArray(array);

        }

        /// <summary>
        /// this method accepts a array of type int. and sort the passed array in ascending order.
        /// </summary>
        /// <param name="arr">The arr.</param>
        void DoBubbleSort(int[] arr)
        {
            int temp = 0;

            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=0;j<arr.Length-1-i;j++)
                {
                    if (arr[j]>=arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


    }
}
