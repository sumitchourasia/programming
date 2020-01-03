using System;

namespace Algorithm
{
    /// <summary>
    /// this BubbleSort Class implements bubble sort to sort integer element in ascending order.
    /// the first pass of bubble sort gives the maximum element.
    /// it takes O(n^2) time complexity in the all cases.
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

            //array to store integer inputs from the user.
            int[] array = new int[len];
            
            
            Console.WriteLine("enter the data in array ");
            //utility method to input the integer array 
            Utility.Util.InputIntArray(array);

            //print the entered array using utility method.
            Console.Write("entered array is : ");
            Utility.Util.PrintArray(array);

            //method to sort the given array using bubble sort.
            Utility.Util.DoBubbleSort(array);

            Console.Write("sorted array is : ");
            //utility method to print the sorted array.
            Utility.Util.PrintArray(array);

        }

    }
}
