using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class PrimeAnagramStackUsingLinkedList<T>
    {

        /// <summary>
        /// Determines whether two primes in the range 0 to 1000 are anagram.
        /// </summary>
        public void PrimeAnagram_StackUsingLinkedList_Method()
        {
            ListNode<T> Head = Utility.CreateStackUsingLinkedList<T>();

            string str1 = "";
            string str2 = " ";
            for (int i = 2; i < 1000; i++)
            {
               // Console.Write(" check if {0} is prime : ",i );
                if (Utility.IsPrime(i))
                {
                    for (int j = 2; j < 1000; j++)
                    {
                        // check if j is prime and i and j are not equal.
                        if (Utility.IsPrime(j) && i != j)
                        {
                            str1 = Convert.ToString(i);
                            str2 = Convert.ToString(j);
                           

                            if (Utility.CheckAnagram(str1, str2))
                            {
                               // Console.WriteLine("compare {0} and {1}", str1, str2);
                                if(!Utility.SearchItem(Head,str1))
                                Head = Utility.PushSLL(Head,(T)((object)str1));

                              //  Console.WriteLine("primes {0} ",str1);
                            }
                        }
                   
                    }

                }

            }



            PrintStackLL(Head);


        }
       
                              
        public void PrintStackLL(ListNode<T> head)
        {
            Utility.PrintLinkedList(head);
        }


    }
}
