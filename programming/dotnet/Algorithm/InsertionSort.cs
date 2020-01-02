using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        /// <summary>
        ///  this method takes the array elements as input and calls DoInsertionSort method to sort the
        ///  given array.
        ///  it takes O(n^2) time complexity in worst case  when every time n inversion happens
        ///  it takes O(n) when elements are already sorted. when no any inversion happen
        /// </summary>
        public void InsertionSortMethod()
        {
            Console.Write("enter the size ot String array : ");
            int len = Utility.Util.ReadInt();

            //string array to store the string input from the user
            String[] array = new String[len];

            Console.WriteLine(" enter the array : ");
            //utility method to input the elements in the array
            Utility.Util.InputStringArray(array);

            Console.Write(" entered array is : ");
            //utility method to print the string array.
            Utility.Util.PrintStringArray(array);

            //utility method call to apply insertion sort on the string array.
            Utility.Util.DoInsertionSort(array);

            //utility method to print the sorted array.
            Console.Write("after insertion sort : ");
            Utility.Util.PrintStringArray(array);

        }



    }
}
