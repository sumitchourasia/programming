using System;

namespace basic
{
    class Factors
    {
        public void FactorMethod()
        {
            Console.WriteLine("enter the number to find the prime factors");
            int number = Utility.Util.ReadInt();
            if(number <=0)
            {
                Console.WriteLine("the number must be a natural number ");
                return;
            }
            int count = FindPrimeFactors(number);
            Console.WriteLine("total count of prime factors are : {0}",count);
        }

        static int FindPrimeFactors(int number)
        {
            int count = 0;
            int i = 2;
            int j = 2;
            bool flag = false;
            while(i*i <= number)
            {
                j = 2;
                flag = false;
                while( j<=Math.Sqrt(i))
                {
                    if(i%j==0)
                    {
                        flag = true;
                    }
                    j++;
                }
                if(number % i == 0 && flag == false )
                {
                    Console.WriteLine(" "+i);
                    count++;
                }
                i++;
            }
            return count;
        }



    }
}
