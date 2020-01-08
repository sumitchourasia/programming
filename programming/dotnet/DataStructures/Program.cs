using System;

namespace DataStructures                 
{
    class Program
    {
        public static void Main( )
        {
            Console.WriteLine("enter your choice : ");
            Console.WriteLine(" 1 -> Un_Ordered_List Program ");
            Console.WriteLine(" 2 -> Ordered_List Program ");
            Console.WriteLine(" 8 -> PrimeNumbersIn2D program ");
            Console.WriteLine(" 9 -> primeNumberAnagram2D program ");
            Console.WriteLine(" 4 -> Banking Cash Counter program");
            Console.WriteLine(" 6 -> Hashing Using linkedlist Program");
            Console.WriteLine("10 -> PrimeAnagram into stack using Linkedlist program ");
            Console.WriteLine(" 3 -> ");

            int k = Utility.ReadInt();

            switch(k)
            {
                case 1:
                    DataStructures.Un_Ordered_List.Un_Ordered_List<string> list = new DataStructures.Un_Ordered_List.Un_Ordered_List<string>();
                    list.Un_Ordered_ListMethod();
                        break;

                case 2:
                    DataStructures.Ordered_List.Ordered_List<string> orderlist = new DataStructures.Ordered_List.Ordered_List<string>();
                    orderlist.Ordered_ListMethod();
                        break;

                case 3:
                    BalancedParanthesis.Balanced_Paranthesis<char> balParan = new BalancedParanthesis.Balanced_Paranthesis<char>();
                    balParan.BalancedParanthesisMethod();
                        break;

                case 4:
                    BankingCashCounter.BankingCashCounter<int> BankQueue = new BankingCashCounter.BankingCashCounter<int>();
                    BankQueue.BankingMethod();
                        break;

                case 6:
                    HashTable.HashingProgram<string> hashing = new HashTable.HashingProgram<string>();
                    hashing.HashingMethod();
                    break;

                case 8:
                    PrimeNumber2D prime = new PrimeNumber2D();
                    prime.PrimeNumber2DMethod();
                    break;

                case 9:
                    PrimeNumberAnagram2D PrimeAnagram = new PrimeNumberAnagram2D();
                    PrimeAnagram.PrimeNumberAnagramMethod();
                    break;

                case 10:
                    PrimeAnagramStackUsingLinkedList<string> AnagramInStack = new PrimeAnagramStackUsingLinkedList<string>();
                    AnagramInStack.PrimeAnagram_StackUsingLinkedList_Method();
                    break;

                case 13:
                    StreamWriterAndReader swr = new StreamWriterAndReader();
                    swr.streamReadWriteMethod();
                    break;

                default :
                    Console.WriteLine("default run ");
                    break;
            }
        }
    }
}
