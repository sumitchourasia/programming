using System;


namespace Functional
{
    /// <summary>
    /// this class is used to find the three integer of the integer array whose sum is 
    /// equal to zero
    /// </summary>
    class TripletSumZero
    {
       public void TripletSumZeroMethod()
        {
            Console.WriteLine("enter the size of array");
            int len = Utility.Util.ReadInt();
            //create an integer array of given size by the user
            int[] arr = new int[len];

            Console.WriteLine("enter the integer values into array");
            //used to enter the integer values into the array 
            Utility.Util.InputIntArray(arr);

            //this method is called to print all the possible triplets whose sum is zero
            //and to return the total number of such triplets
            int count=FindTripletSumZero(arr);

            Console.WriteLine("total number of triplets whose sum is zero are {0}",count);

        }

        /// <summary>
        /// Finds the all the possible triplets whose sum equates to zero.
        /// and return count
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>integer count</returns>
        static int FindTripletSumZero(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    for (int k = j; k < arr.Length; k++)
                    {
                        // check if the sum equates to zero and check if the integers are distinct.
                        if (arr[i] + arr[j] + arr[k] == 0 && arr[i] != arr[j] && arr[i] != arr[k] && arr[j] != arr[k])
                        {
                            count++;
                            Console.WriteLine("{0} + {1} + {2} = 0", arr[i], arr[j], arr[k]);
                        }
                    }
                }
            }
            return count;
        }
    }
}
