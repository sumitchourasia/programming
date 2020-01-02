using System;


namespace Algorithm
{
    /// <summary>
    /// BinarySearch class to apply binary search process to the given string array by user
    /// first it sorts the given array using insertion sort 
    /// then calls DoBinarySearch method on the sorted array and return the index if data is found.
    /// otherwise it returns -1
    /// it takes O(nlog) time complexity in wosrt case when element is not in the middle
    /// it takes O(1) in best case when element is at the middle.
    /// </summary>
    class BinarySearch
    {
        /// <summary>
        /// BinarySearchMethod first it sorts the given array using insertion sort 
        /// then calls DoBinarySearch method on the sorted array and return the index if data is found.
        /// otherwise it returns -1
        /// </summary>
        public void BinarySearchMethod()
        {
            Console.Write("enter the length of the array : ");
            int len = Utility.Util.ReadInt();
            //string array for taking the string input from user.
            string[] strarray = new string[len];

            //utility method to take the string array as input from user.
            Utility.Util.InputStringArray(strarray);

            //utility method to sort the inputed string array using insertion sort
            Utility.Util.DoInsertionSort(strarray);

            //Utility method to print the sorted string array.
            Utility.Util.PrintStringArray(strarray);

            //take the data from the keyboard to look for in the sorted array 
            Console.Write("enter the data to look for : ");
            string data = Utility.Util.ReadString();

            //DoBinarySearch method called to look for the data in the sorted array using binary search 
            int index = DoBinarySearch(strarray,0,strarray.Length-1,data);

            //if data found then return the index else return -1;
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
                //calculate the middle index.
                int middle = (first + last) / 2;
                
                //if the data is at middle index then return index.
                if (data.CompareTo(strarr[middle])==0)
                {
                    return middle;
                }
                else if (first >= last)  //termination condition
                {
                    return -1;
                }
                else if ((data.CompareTo(strarr[middle]))<0) //go left.
                {
                    return DoBinarySearch(strarr, first, middle, data);
                }
                else //go right.
                {
                    return DoBinarySearch(strarr, middle+1, last, data);
                }
            }
        }
    }
