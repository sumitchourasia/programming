using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
    /// <summary>
    /// class to convert a number(base 10) to its equivalent binary representation (base 2)
    /// and swap the nibbles and check if swapped numbers' decimal equivalent is power of two.
    /// </summary>
    class ToBinaryAndSwapNibble
    {
        /// <summary>
        /// this method takes interger input and calls 
        /// </summary>
        public void ToBinaryAndSwapNibbleMethod()
        {
            Console.Write("enter the deciaml number : ");
            int n = Utility.Util.ReadInt();

            //make sure the binary array has completes nibbles in it.
            int size = Utility.Util.CalculateBinaryArraySize(n);

            int[] binaryarray = new int[size];
            
            //utility method called to convert the input nummber(base 10) to equivalent number of base 2.
            Utility.Util.ToBinary(n,binaryarray);

            //utility method to print the binary representation.
            Utility.Util.PrintBinaryArray(binaryarray);

            //class method called to swap the two nibbles.
            SwapNibble(binaryarray,0,4);

            Console.WriteLine("After swapping nibble : ");

            //method to print binary representation after swapping the nibbles.
            Utility.Util.PrintBinaryArray(binaryarray);

            //method call to convert the swapped binary(base 2) representation to the decimal number(base 10) 
            int decimalvalue=ToDecimal(binaryarray);
            
            Console.WriteLine("\n decimal value after swapping th nibble : {0}",decimalvalue);

            //method call to check id the swapped number is a power of two.
            bool isPoweroftwo = IsPowerOfTwo(decimalvalue);

            if(isPoweroftwo==true)
            {
                Console.WriteLine("the swapped value is a power of 2");
            }
            else
            {
                Console.WriteLine("the swapped value is not a power of 2");
            }

        }

        /// <summary>
        /// method to Swap the nibbles of the biinary representation.
        /// it takes three parameters.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        void SwapNibble(int[] arr,int i,int j)
        {
            int temp = 0;
            for(int k=0;k<=3;k++)
            {
                temp = arr[i+k];
                arr[i+k] = arr[j+k];
                arr[j+k]= temp;
            }

        }

        /// <summary>
        /// Converts the binary(base 2) representation to decimal(decimal).
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns></returns>
        int ToDecimal(int[] arr)
        {
            int decimalsum= 0;
            int power = arr.Length - 1;
            for (int i = 0; i < arr.Length; i++,power--)
            {
                if(arr[i] != 0)
                {
                    decimalsum +=  (arr[i] *(int)Math.Pow(2 , power));
                }
            }

            return decimalsum;
        }

        /// <summary>
        /// Determines whether the passes arrgument is a power of 2.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if [is power of two] [the specified n]; otherwise, <c>false</c>.
        /// </returns>
        bool IsPowerOfTwo(int n)
        {
            while(n>1)
            {
                if(n%2==1)
                {
                    return false;
                }
                else
                {
                    n = n / 2;
                }

            }
            return true;
        }


    }
}










