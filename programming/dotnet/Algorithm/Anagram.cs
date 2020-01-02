using System;
using System.Collections.Generic;
using System.Text;

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
            if(CheckAnagram(str1,str2))
            {
                Console.WriteLine(" is anagram ");
            }
            else
            {
                Console.WriteLine(" not anagram");
            }
        }


        /// <summary>
        /// this method takes two string paramters and Checks whether two string the anagram
        /// and return boolean value
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns></returns>
        bool CheckAnagram(string str1,string str2)
        {
            if(str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                bool flag = true;
                //character array to store the string1 as character
                char[] chararr1 = new char[str1.Length]; 
                chararr1 = str1.ToCharArray();

                //charcter array to store the string2 as character 
                char[] chararr2 = new char[str2.Length];
                chararr2 = str2.ToCharArray();


                for(int i=0 ; i<chararr1.Length ; i++)
                {
                    for(int j=0 ; j<chararr2.Length ; j++)
                    {
                        //compare each element of chararr1 with all the elements of chararr2
                        //where element is not a space character.
                        if (chararr1[i] == chararr2[j] && chararr1[i]!=' ')
                        {
                            //if found equal then replace with space character
                            chararr1[i] = ' ';
                            chararr2[j] = ' ';
                            break;
                        }
                    }
                }

                //check if all characters of both the array are spaces.
                //this indicates that all the characters has matched in both the array.
                for(int i=0;i<chararr1.Length;i++)
                {
                    //if any one character remains that is not a space character this indicates that 
                    //all characters in both the array did not match.
                    if (chararr1[i] != ' ' || chararr2[i] != ' ')
                    {
                        return false;
                    }                
                }
                return flag;
            }

            
        }


    }
}
