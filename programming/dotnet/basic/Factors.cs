using System;

namespace basic
{
    /// <summary>
    /// class to print the prime factors of a number.
    /// </summary>
    class Factors
    {
        /// <summary>
        /// this method is used to print the Factors of the given input number.
        /// </summary>
        public void FactorMethod()
        {
            Console.WriteLine("enter the number to find the prime factors");
            int number = Utility.Util.ReadInt();
            //check validity of the number
            if(number <=0)
            {
                Console.WriteLine("the number must be a natural number ");
                return;
            }

            //method call to find all the prime factors of the number
            int count = FindPrimeFactors(number);
            Console.WriteLine("total count of prime factors are : {0}",count);
        }

        /// <summary>
        /// method to Find the prime factors of the given number.
        /// takes an integer number as a parameter.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        static int FindPrimeFactors(int number)
        {
            int count = 0;
            int i = 2;
            int j = 2;
            bool flag = false;

            // check with i*i to increase the efficiency 
            //loop through the values to check if the given number has any factor.
            while(i*i <= number)
            {
                j = 2;
                flag = false;

                //first check if the divisor itself have any factor.
                while( j<=Math.Sqrt(i))
                {
                    if(i%j==0)
                    {
                        flag = true;
                        break;
                    }
                    j++;
                }

               //if the divisor itself does not have any factor and the given number is divided by the divisor 
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
