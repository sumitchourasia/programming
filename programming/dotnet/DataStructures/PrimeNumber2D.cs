using System;

namespace DataStructures
{
    class PrimeNumber2D
    {
        public void PrimeNumber2DMethod()
        {
            int[][] array = new int[10][];
            for(int i=0;i<10;i++)
            {
                array[i] = new int[100];
            }

            int number = 1;
            int m = 0;
            
            for(int i=0;i<10;i++)
            {
                //take m and n to insert the prime number continuously.
                //to increase the efficiency.
                int n = 0;
                for (int j=0;j<100;j++)
                {
                    if(Utility.IsPrime(number))
                    {
                        array[m][n] = number;
                        n++;
                    }
                    number++;
                }
                m++;
            }

            ////to print the prime numbers in the 2d array except 0.
            Utility.PrintPrimeNumberIn2D(array);

        }


      

    }
}
