using System;

namespace DataStructures
{
    class PrimeNumberAnagram2D
    {
        public void PrimeNumberAnagramMethod()
        {
            int[][] PrimeArray = new int[10][];
            int[][] AnagramArray = new int[10][];

            for (int i = 0; i < 10; i++)
            {
                PrimeArray[i] = new int[100];
                AnagramArray[i] = new int[100];
            }

            InsertPrimesIn2DArray(PrimeArray);



            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (PrimeArray[i][j] != 0)
                    {

                        InsertThePrimeAnagramsIn2DArray(AnagramArray, PrimeArray, PrimeArray[i][j]);

                       
                    }

                }

            }

                Console.WriteLine("\n primes are : ");
                Utility.PrintPrimeNumberIn2D(PrimeArray);

                Console.WriteLine("\n \n method call anagrams are : ");

                ////print the Anagrams.
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (AnagramArray[i][j] != 0)
                        {
                            Console.Write(" {0}", AnagramArray[i][j]);
                        }
                    }
                    Console.WriteLine(" ");
                }

            }




            void InsertPrimesIn2DArray(int[][] Array)
            {
                //insert the primes.
                int number = 1;
                int m = 0;
                for (int i = 0; i < 10; i++)
                {
                    int n = 0;
                    for (int j = 0; j < 100; j++)
                    {
                        if (Utility.IsPrime(number))
                        {
                            Array[m][n] = number;
                            n++;
                        }
                        number++;
                    }
                    m++;
                }

            }




            void InsertThePrimeAnagramsIn2DArray(int[][] AnagramArray, int[][] PrimeArray, int prime)
            {
                string str1 = Convert.ToString(prime);
                string str2 = "";
                for (int p = 0; p < 10; p++)
                {
                    for (int q = 0; q < 100; q++)
                    {
                        if (PrimeArray[p][q] != 0)
                        {
                            str2 = Convert.ToString(PrimeArray[p][q]);

                            if (Utility.CheckAnagram(str1, str2) && !str1.Equals(str2))
                            {
                                AnagramArray[p][q] = PrimeArray[p][q];
                                return;
                            }
                        }
                    }
                }

            }


    }
}


