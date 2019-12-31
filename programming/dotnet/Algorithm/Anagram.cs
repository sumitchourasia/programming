using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Anagram
    {
        public void AnagramMethod()
        {
            Console.WriteLine("enter first string ");
            string str1 = Utility.Util.ReadString();

            Console.WriteLine("enter the second string ");
            string str2 = Utility.Util.ReadString();

            if(CheckAnagram(str1,str2))
            {
                Console.WriteLine(" is anagram ");
            }
            else
            {
                Console.WriteLine(" not anagram");
            }
        }

        bool CheckAnagram(string str1,string str2)
        {
            if(str1.Length != str2.Length)
            {
                return false;
            }
            else
            {
                bool flag = true;
                char[] chararr1 = new char[str1.Length]; 
                chararr1 = str1.ToCharArray();

                char[] chararr2 = new char[str2.Length];
                chararr2 = str2.ToCharArray();

                for(int i=0 ; i<chararr1.Length ; i++)
                {
                    for(int j=0 ; j<chararr2.Length ; j++)
                    {
                        if (chararr1[i] == chararr2[j] && chararr1[i]!=' ')
                        {
                            chararr1[i] = ' ';
                            chararr2[j] = ' ';
                            break;
                        }
                    }
                }

                for(int i=0;i<chararr1.Length;i++)
                {
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
