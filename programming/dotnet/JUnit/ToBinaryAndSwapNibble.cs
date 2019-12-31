using System;
using System.Collections.Generic;
using System.Text;

namespace JUnit
{
    class ToBinaryAndSwapNibble
    {
        public void ToBinaryAndSwapNibbleMethod()
        {
            Console.Write("enter the deciaml number : ");
            int n = Utility.Util.ReadInt();

            int size = Utility.Util.CalculateBinaryArraySize(n);
            int[] binaryarray = new int[size];
            
            Utility.Util.ToBinary(n,binaryarray);

            Utility.Util.PrintBinaryArray(binaryarray);

            SwapNibble(binaryarray,0,4);

            Console.WriteLine("After swapping nibble : ");

            Utility.Util.PrintBinaryArray(binaryarray);

            int decimalvalue=ToDecimal(binaryarray);
            
            Console.WriteLine("\n decimal value after swapping th nibble : {0}",decimalvalue);

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










