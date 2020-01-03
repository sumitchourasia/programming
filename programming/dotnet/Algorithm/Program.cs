using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select your choice : ");
            Console.WriteLine(" 1 -> Permutations Of a String  program ");
            Console.WriteLine(" 2 -> Binary Search the Word from Word List program ");
            Console.WriteLine(" 3 -> Insertion Sort program ");
            Console.WriteLine(" 4 -> Bubble Sort program ");
            Console.WriteLine(" 5 -> Merger Sort program ");
            Console.WriteLine(" 6 -> Anagram Detection program ");
            Console.WriteLine(" 7 -> Prime Number program ");
            Console.WriteLine(" 8 -> Primenumber_Palindrome_Anagram  program ");
            Console.WriteLine(" 9 ->                           program ");
            Console.WriteLine("10 -> Guess Number Game program ");
            Console.WriteLine("11 -> ListOfTask program ");
            Console.WriteLine("12 ->                           program ");

            Console.Write("enter your choice : ");
            int choice = Utility.Util.ReadInt();

            switch(choice)
            {
                case 1:
                    StringPermutation sp = new StringPermutation();
                    sp.StringPermutationMethod();
                    break;

                case 2:
                    BinarySearch binarysearch = new BinarySearch();
                    binarysearch.BinarySearchMethod();
                    break;
                case 3:
                    InsertionSort insertionsort = new InsertionSort();
                    insertionsort.InsertionSortMethod();
                    break;

                case 4:
                    BubbleSort bubblesort = new BubbleSort();
                    bubblesort.BubbleSortMethod();
                    break;

                case 5:
                    MergeSort mergesort = new MergeSort();
                    mergesort.MergeSortMethod();
                    break;

                case 6:
                    Anagram anagram = new Anagram();
                    anagram.AnagramMethod();
                    break;

                case 7:
                    PrimeNumber prime = new PrimeNumber();
                    prime.PrimeNumberMethod();
                    break;

                case 8:
                    PalindromeAndAnagram pna = new PalindromeAndAnagram();
                    pna.PalindromeAndAnagramMethod();
                    break;

                case 10:
                    GuessNumber guessnumber = new GuessNumber();
                    guessnumber.GuessNumberMethod();
                    break;

                case 11:
                    ListOfTask lot = new ListOfTask();
                    lot.ListOfTaskMethod();
                    break;
                default :

                    break;
            }
        }
    }
}










