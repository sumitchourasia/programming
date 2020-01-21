using System;

namespace OOPs.DeckOfCards
{
    /// <summary>
    /// utility class
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Initializes the card array.
        /// </summary>
        /// <param name="CardArray">The card array.</param>
        /// <param name="Suits">The suits.</param>
        /// <param name="Ranks">The ranks.</param>
        public static void InitializeCardArray(string[,] CardArray, string[] Suits, string[] Ranks)
        {
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 13; j++)
                    CardArray[i, j] = Suits[i] + "-" + Ranks[j]+" ";
        }

        /// <summary>
        /// Generates the random.
        /// </summary>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static int GenerateRandom(int max)
        {
            Random rd = new Random();
            return rd.Next(max);
        }

        /// <summary>
        /// Prints the string 2-D array.
        /// </summary>
        /// <param name="Array">The array.</param>
        public static void PrintString2DArray(string[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                    Console.Write(Array[i, j]);
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Shuffles the given string 2-D Array
        /// </summary>
        /// <param name="Array">The array.</param>
        public static void ShuffleCards(string[,] Array)
        {
            int rowIndex1 = 0;
            int coloumnIndex1 = 0;
            int rowIndex2 = 0;
            int coloumnIndex2 = 0;
            for (int i = 0;i<52;i++)
            {
                 rowIndex1 = GenerateRandom(Array.GetLength(0));
                 coloumnIndex1 = GenerateRandom(Array.GetLength(1));
                 rowIndex2 = GenerateRandom(Array.GetLength(0));
                 coloumnIndex2 = GenerateRandom(Array.GetLength(1));
                 Swap(Array,rowIndex1,coloumnIndex1,rowIndex2,coloumnIndex2);
            }
        }

        /// <summary>
        /// Swaps the specified array.
        /// </summary>
        /// <param name="Array">The array.</param>
        /// <param name="rowIndex1">The row index1.</param>
        /// <param name="coloumnIndex1">The coloumn index1.</param>
        /// <param name="rowIndex2">The row index2.</param>
        /// <param name="coloumnIndex2">The coloumn index2.</param>
        public static void Swap(string[,] Array , int rowIndex1 , int coloumnIndex1, int rowIndex2,int coloumnIndex2)
        {
            string temp = Array[rowIndex1, coloumnIndex1];
            Array[rowIndex1, coloumnIndex1] = Array[rowIndex2, coloumnIndex2];
            Array[rowIndex2, coloumnIndex2] = temp;
        }

        /// <summary>
        /// Distributes the 9 cards to each of the 4 player
        /// </summary>
        /// <param name="CardArray">The card array.</param>
        /// <param name="PlayerArray">The player array.</param>
        public static void DistributeCards(string[,] CardArray , string[,] PlayerArray)
        {
            for(int i=0;i<4;i++)
                for(int j=0;j<9;j++)
                    PlayerArray[i,j] = CardArray[i,j];
        }

    }
}
