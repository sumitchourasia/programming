using System;

namespace Algorithm
{

    /// <summary>
    /// class to check that a primes that are palindrome and anagrams
    /// </summary>
    class PalindromeAndAnagram
    {
        /// <summary>
        /// this method calls three method IsPrime() and IsPalindrome() and CheckAnagram() 
        /// to print all the primes that are palindrome and anagram.
        /// </summary>
        public void PalindromeAndAnagramMethod()
        {
            for (int i = 10; i <= 1000; i++)
            {
                // check if a number is prime and plindrome
                if (Utility.Util.IsPrime(i) && IsPalindrome(i)==true)
                {
                    Console.WriteLine("number {0} is palindrome",i);
                }
            }

            IsAnagram();
        }

        /// <summary>
        /// Determines whether the specified number is palindrome.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is palindrome; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Determines whether two primes in the range 0 to 1000 are anagram.
        /// </summary>
        void IsAnagram()
        {
            string str1 = "";
            string str2 = " ";
            for (int i = 2; i < 1000; i++)
            {
                //check if i is prime
                if (Utility.Util.IsPrime(i))
                {

                    for (int j = 2; j < 1000; j++)
                    {    
                        // check if j is prime and i and j are not equal.
                        if (Utility.Util.IsPrime(j) && i != j)
                        {
                            str1 = Convert.ToString(i);
                            str2 = Convert.ToString(j);
                            if (Utility.Util.CheckAnagram(str1, str2))
                            {
                                Console.WriteLine("primes {0} and  {1} are anagrams ", i, j);
                            }
                        }

                    }
                }
            }

        }
    }
}
