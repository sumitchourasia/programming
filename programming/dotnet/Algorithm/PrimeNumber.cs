using System;


namespace Algorithm
{
    class PrimeNumber
    {
        public void PrimeNumberMethod()
        {
            Console.WriteLine("program for printing the prime numbers in a range of 1 to 1000");
            for(int i=2;i<=1000;i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine("  {0}",i);
                }
            }
        }

        bool IsPrime(int n)
        {
            bool flag = true;

            for(int i=2;i<=Math.Sqrt(n);i++)
            {
                if(n%i==0)
                {
                    flag = false;
                    return flag;
                }
            }

            return flag;
        }




    }
}
