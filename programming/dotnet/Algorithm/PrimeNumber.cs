using System;


namespace Algorithm
{
    /// <summary>
    /// this class is used to print all the prime numbers between 1 to 1000
    /// </summary>
    class PrimeNumber
    {
        public void PrimeNumberMethod()
        {
            Console.WriteLine("program for printing the prime numbers in a range of 1 to 1000");
            for(int i=2;i<=1000;i++)
            {
                if (Utility.Util.IsPrime(i))
                {
                    Console.WriteLine("  {0}",i);

                }
            }
        }

    }
}
