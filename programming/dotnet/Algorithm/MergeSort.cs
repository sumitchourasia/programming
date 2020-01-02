using System;

namespace Algorithm
{
    /// <summary>
    /// Mergesort class is used to take string array as input and sorts it 
    /// it takes O(nlogn) time-complexity in all cases once the algorithm starts there is no return in between.
    /// </summary>
    class MergeSort 
    {
        /// <summary>
        /// MergeSortMethod is used to merge the array 
        /// it takes input string array from the user
        /// and calls RecursiveMergeSort() method to sort the string array
        /// and prints the sorted array using utility method called PrintStringArray() method
        /// </summary>
        public void MergeSortMethod()
        {
            Console.WriteLine("enter the size of array : "); 
             int len = Utility.Util.ReadInt(); 

            string[] array = new string[len];

            Console.WriteLine("enter the array element"); 

            //utility method to enter the elements into string array
            Utility.Util.InputStringArray(array);
            
            //utility method to print the string array;
            Utility.Util.PrintStringArray(array); 
            
            //method call to sort the string array using recusrsive merge sort.
            //merge sort outplace takes nlog time complexity.
            RecursiveMergeSort(array, 0, array.Length - 1);

            //utility method to print the string array;
            Utility.Util.PrintStringArray(array); 

        }

        /// <summary>
        /// sorts the given string array using merge sort.
        /// it takes three parameters.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="last">The last.</param>
        void RecursiveMergeSort(string[] array, int start, int last)
        {
            //termination condition
            if (start == last)
            {
                return;
            }
            else 
            {
                //find middle element index.
                int mid = (start + last) / 2;
                
                //conquer part :- go left
                RecursiveMergeSort(array, start, mid);
                //conquer part :- go right
                RecursiveMergeSort(array, mid + 1, last);

                //combine part : using outplace(extra array) to combine the divide parts of string array
                MergeAlgo(array,start,mid,mid+1,last);

            }
        }

        /// <summary>
        /// MergeAlgo method facilitaes the combine part.
        /// MergeAlgo to merge the divided parts of array by comparing and placeing the elements in 
        /// sorted order in the string array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="start">The start.</param>
        /// <param name="midl">The midl.</param>
        /// <param name="midr">The midr.</param>
        /// <param name="last">The last.</param>
        void MergeAlgo(string[] array,int start,int midl,int midr,int last)
        {
            string[] left = new string[midl-start+1];
            string[] right = new string[last-midr+1];
            int st = start;
            int md = midr;

            //left part is stored in left array.
            for(int m=0;m<left.Length;m++,st++)
            {
                left[m] = array[st];
            }
            
            //right part is stored in the right array.
            for(int n=0;n<right.Length;n++,md++)
            {
                right[n] = array[md];
            }

            int i = 0;
            int j = 0;
            int k = start;
            //compare the two array left and right successively untill any one of the array completes.
            while(i<left.Length && j<right.Length)
            {
                if(left[i].CompareTo(right[j])==-1)
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            //place the remaining elements of left array in the main string array
            while(i<left.Length)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            //place the remaining elements of right array in the main string array.
            while(j<right.Length)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
