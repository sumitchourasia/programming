using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        /// <summary>
        ///  this method takes the array elements as input and calls DoInsertionSort method to sort the given array.
        /// </summary>
        public void InsertionSortMethod()
        {
            Console.Write("enter the size ot String array : ");
            int len = Utility.Util.ReadInt();

            String[] array = new String[len];

            Console.WriteLine(" enter the array : ");
            Utility.Util.InputStringArray(array);

            Console.Write(" entered array is : ");
            Utility.Util.PrintStringArray(array);

            Utility.Util.DoInsertionSort(array);

            Console.Write("after insertion sort : ");
            Utility.Util.PrintStringArray(array);

        }



    }
}
