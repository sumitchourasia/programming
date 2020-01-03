using System;

namespace Algorithm
{
    /// <summary>
    /// this class is used to check if two given string are anagram or not
    /// </summary>
    class Anagram
    {
        /// <summary>
        /// this method takes two string input from the user and calls the checkAnagram method 
        /// </summary>
        public void AnagramMethod()
        {
            Console.WriteLine("enter first string ");
            string str1 = Utility.Util.ReadString();

            Console.WriteLine("enter the second string ");
            string str2 = Utility.Util.ReadString();

            //method call to check if two strings are anagram.
            if( Utility.Util.CheckAnagram(str1,str2))
            {
                Console.WriteLine(" is anagram ");
            }
            else
            {
                Console.WriteLine(" not anagram");
            }
        }
            
        }

    }
