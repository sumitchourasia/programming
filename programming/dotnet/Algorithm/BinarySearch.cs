using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// BinarySearch class 
    /// </summary>
    class BinarySearch
    {
        public void BinarySearchMethod()
        {
            Console.Write("enter the length of the array : ");
            int len = Utility.Util.ReadInt();
            string[] strarray = new string[len];
            Utility.Util.InputStringArray(strarray);

            Utility.Util.DoInsertionSort(strarray);

            Utility.Util.PrintStringArray(strarray);

            Console.Write("enter the data to look for : ");
            string data = Utility.Util.ReadString();

            int index = DoBinarySearch(strarray,0,strarray.Length-1,data);
            if(index == -1)
            {
                Console.Write("data not found");
            }
            else
            {
                Console.Write("data is at index {0}",index);
            }
        }


        /// <summary>
        /// Does the binary search. 
        /// takes four parameters and returns -1 if data is not found or if data is found
        /// then this method returns the index of the data in the  sorted array
        /// </summary>
        /// <param name="strarr">The strarr.</param>
        /// <param name="first">The first.</param>
        /// <param name="last">The last.</param>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        int DoBinarySearch(string[] strarr,int first,int last,string data)
        {
                int middle = (first + last) / 2;

                if (data.CompareTo(strarr[middle])==0)
                {
                    return middle;
                }
                else if (first >= last)
                {
                    return -1;
                }
                else if ((data.CompareTo(strarr[middle]))<0)
                {
                    return DoBinarySearch(strarr, first, middle, data);
                }
                else 
                {
                    return DoBinarySearch(strarr, middle+1, last, data);
                }
            }
        }
    }
