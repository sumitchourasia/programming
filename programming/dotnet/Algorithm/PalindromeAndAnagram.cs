using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PalindromeAndAnagram
    {
        public void PalindromeAndAnagramMethod()
        {
            bool flag = false;
            for (int i = 10; i <= 1000; i++)
            {
                // check if a number is prime and plindrome
                if (Utility.Util.IsPrime(i) && IsPalindrome(i)==true)
                {
                    Console.WriteLine(" {0}",i);
                }
            }
        }


        bool IsPalindrome(int number)
        {
            int reverse = 0;
            int remainder = 0;
            int num = number;
            
            while(num>0)
            {
                remainder = num % 10;
                num = num / 10;
                reverse = reverse * 10 + remainder;
            }
            if( reverse == number)
            {
                return true;
            }

            return false;
        }
    }
}
