﻿using System;

namespace Utility
{
    public class Util
    {
            /// <summary>
            /// Reads the int.
            /// method to read integer from keyboard and return it
            /// </summary>
            /// <returns></returns>
            public static int ReadInt()
            {
                    int input = 0;
                    bool success = false;
                    while (true)
                    {
                        try
                        {
                            success = Int32.TryParse(Console.ReadLine(), out input);

                            if (success)
                            {
                                return input;
                            }
                           
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(" enter a valid integer input ");
                        }
                    }
            }


        /// <summary>
        /// Reads the double.
        /// method to read double from keyboard and return it
        /// </summary>
        /// <returns>double value</returns>
        public static double ReadDouble()
        {
            double input = 0.0;
            bool success = false;
            while (true)
            {
                try
                {
                    success = double.TryParse(Console.ReadLine(), out input);

                    if (success)
                    {
                        return input;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(" enter a valid Double input ");
                }
            }
        }


        /// <summary>
        /// Reads the boolean.
        /// method to read double from keyboard and return it
        /// </summary>
        /// <returns>double value</returns>
        public static bool ReadBoolean()
        {
            bool input = false;
            bool success = false;
            while (true)
            {
                try
                {
                    success = bool.TryParse(Console.ReadLine(), out input);
                    if (success)
                    {
                        return input;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(" enter a valid Boolean input ");
                }
            }
        }



        /// <summary>
        /// Reads the string.
        /// method to read string from keyboard and return it
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
            {
                return Console.ReadLine();
            }


        /// <summary>
        /// Generates and returns the Random number .
        /// </summary>
        /// <returns></returns>
        public static int GenerateRandomInteger(int max)
        {
            Random rd = new Random();
            return rd.Next(max);
        }

        /// <summary>
        /// Prints the one dimensional character array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void PrintCharArray(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine(" ");
        }




        /// <summary>
        /// Prints the one dimensional integer array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine(" ");
        }


        /// <summary>
        /// Prints the string array.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void PrintStringArray(String[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                Console.Write("  {0}",array[i]);
            }
            Console.WriteLine("  ");
        }



        /// <summary>
        /// Prints the binary array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void PrintBinaryArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}", arr[i]);
                if ((i + 1) % 4 == 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine(" ");
        }


        /// <summary>
        /// IntArray method is used to declare a one dimensional integer array and return the reference
        /// of that array
        /// </summary>
        /// <returns>one dimensional integer array</returns>
        public static void InputIntArray(int[] intarr)
        {
            for (int i = 0; i < intarr.Length; i++)
            {
               intarr[i] = Utility.Util.ReadInt();
            }
            
        }


        /// <summary>
        /// this method takes string array as parameter and Inputs the string array.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void InputStringArray(String[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                array[i] = ReadString();
            }
        }





        /// <summary>
        /// Inputs the distinct array
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void InputDistinctArray(int[] arr)
        {
            bool IsPresent = false;
            int data = -1;
           for(int i=0;i<arr.Length;i++)
            {
                Console.Write("enter the data : ");
                data = ReadInt();
                for (int j=0;j<=i;j++)
                {
                    if(arr[j] == data)
                    {
                        i--;
                        IsPresent = true;
                        Console.WriteLine(" already present");
                        break;
                    }
                }
                if(IsPresent==false)
                {
                    arr[i] = data;
                }
            }
        }


        /// <summary>
        /// TwoDIntArray method is used to declare a two dimensional integer array and return the reference
        /// of that array
        /// </summary>
        /// <returns>two dimensional integer array</returns>
        public static void InputTwoDIntArray(int[,] intarr)
            {
                 for(int i=0;i<3;i++)
                 {
                    for(int j=0;j<3;j++)
                    {
                        intarr[i,j] = Utility.Util.ReadInt();
                    }
                 }
            return ;
            }



        /// <summary>
        /// TwoDdoubleArray method is used to declare a two dimensional double array and return the reference
        /// of that array
        /// </summary>
        /// <returns>two dimensional double array</returns>
        public static void InputTwoDDoubleArray(double[,] intarr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    intarr[i, j] = ReadDouble();
                }
            }
            return ;
        }



        /// <summary>
        /// TwoDBooleanArray method is used to declare a two dimensional Boolean array and return the reference
        /// of that array
        /// </summary>
        /// <returns>two dimensional Boolean array</returns>
        public static void InputTwoDBooleanArray(bool[,] boolarr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boolarr[i, j] = ReadBoolean();
                }
            }
            return ;
        }


        /// <summary>
        /// Prints the two dimensional integer array.
        /// </summary>
        /// <param name="intarr">two dimensional integer array</param>
        public static void PrintTwoDIntArray(int[,] intarr)
        {
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(intarr[i,j]);
                }
                Console.WriteLine();
            }
        }



        /// <summary>
        /// Prints the two dimensional Double array.
        /// </summary>
        /// <param name="doublearr">two dimensional Double array</param>
        public static void PrintTwoDDoubleArray(double[,] doublearr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(doublearr[i, j]);
                }
                Console.WriteLine();
            }
        }



        /// <summary>
        /// Prints the two dimensional Boolean array.
        /// </summary>
        /// <param name="intarr">two dimensional Boolean array</param>
        public static void PrintTwoDBooleanArray(bool[,] boolarr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(boolarr[i, j]);
                }
                Console.WriteLine();
            }
        }



        /// <summary>
        /// CheckLeapYear method is used to check if a given method is leap year 
        /// and returns a boolean true or false
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static bool CheckLeapYear(int year)
        {

            return ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));

        }



        /// <summary>
        /// Calculates the day of week.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="m">The m.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public static int CalculateDayOfWeek(int d, int m, int y)
        {
            int d0 = 0;
            int m0 = 0;
            int y0 = 0;
            int x = 0;

           

            //formulas to calculate the day.
            y0 = y - (14 - m) / 12;

            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);

            m0 = m + 12 * ((14 - m) / 12) - 2;

            d0 = (d + x + (31 * m0) / 12) % 7;

            return d0;
        }


        /// <summary>
        /// Calculates the square root using newton formula method.
        /// </summary>
        /// <param name="c">double </param>
        /// <returns></returns>
        public static double CalculateNewtonSqrt(int c)
        {
            double t = (double) c;

            while (Math.Abs(t - c / t) > Double.Epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }

            return t;
        }


        /*
        public static void toBinary(int n)
        {
            int[] arr = new int[12];
            int bit = 0;
            int i = arr.Length - 1;
            int count = arr.Length - 1;
            while (n > 0)
            {
                count--;
                bit = n % 2;
                n = n / 2;
                arr[i--] = bit;
            }

            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == 1)
                {
                    Console.WriteLine((int)Math.Pow(2, (arr.Length - 1 - j)));
                    if (j != 0)
                        Console.WriteLine(" + ");
                }
            }

            Console.WriteLine(" ");

            for (int j = count + 1; j < arr.Length; j++)
            {
                int k = 0;
                if (k % 4 == 0)
                    Console.WriteLine(" ");
                Console.WriteLine(" {0}", arr[j]);
            }

        }

    */

        /// <summary>
        /// Calculates the size of the binary array.
        /// </summary>
        /// <param name="n">The n (decimal).</param>
        /// <returns>size of rhe array that is required</returns>
        public static int CalculateBinaryArraySize(int n)
        {
            int count = 0;
            while (n > 0)
            {
                count++;
                n = n / 2;
            }
            //append the extra bits to make it a complete nibble.
            int temp1 = count % 4;
            int temp2 = 0;
            if (temp1 != 0)
            {
                temp2 = 4 - temp1;
                count += temp2;
            }

            return count;
        }


        /// <summary>
        /// Converts to binary.
        /// </summary>
        /// <param name="n">The n (decimal)</param>
        /// <param name="arr">The array to store the binary representation.</param>
        /// <returns></returns>
        public static int[] ToBinary(int n, int[] arr)
        {
            int i = 0;
            while (n > 0)
            {
                arr[arr.Length - i - 1] = n % 2;
                i++;
                n = n / 2;
            }
            return arr;
        }


        /// <summary>
        /// this method accepts a array of type int. and sort the passed array in ascending order.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void DoBubbleSort(int[] arr)
        {
            int temp = 0;

            //loop through the array.
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //if condition satisfies then swap the elements.
                    if (arr[j] >= arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }


        /// <summary>
        /// Does the insertion sort.
        /// </summary>
        /// <param name="array">The array.</param>
        public static void DoInsertionSort(String[] array)
        {
            int j = 0;
            String key = "";
            for (int i = 0; i < array.Length; i++)
            {
                key = array[i];
                j = i - 1;
                while (j >= 0)
                {
                    if (array[j].CompareTo(key) == 1)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                array[j + 1] = key;
            }

        }




        /// <summary>
        /// Factorials the specified n.
        /// takes integer as parameter and returns an integer
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public static int factorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }

        }


        /// <summary>
        /// Checks the two distinct string array are equal or not.
        /// take two string array and compares them
        /// </summary>
        /// <param name="arr1">The arr1.</param>
        /// <param name="arr2">The arr2.</param>
        /// <returns></returns>
        public static bool CheckTwoDistinctStringArrayEqual(string[] arr1, string[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            else
            {
                int count = 0;

                for (int i = 0; i < arr1.Length; i++)
                {

                    for (int j = 0; j < arr2.Length; j++)
                    {

                        if (arr1[i] == arr2[j])
                        {
                            count++;
                        }
                    }
                }
                if (count == arr1.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Determines whether the specified n is prime.
        /// return a boolean value
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns>
        ///   <c>true</c> if the specified n is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int n)
        {
            bool flag = true;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    flag = false;
                    return flag;
                }
            }

            return flag;
        }



        /// <summary>
        /// this method takes two string paramters and Checks whether two string the anagram
        /// and return boolean value
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns></returns>
        public static bool CheckAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
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


                for (int i = 0; i < chararr1.Length; i++)
                {
                    for (int j = 0; j < chararr2.Length; j++)
                    {
                        //compare each element of chararr1 with all the elements of chararr2
                        //where element is not a space character.
                        if (chararr1[i] == chararr2[j] && chararr1[i] != ' ')
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
                for (int i = 0; i < chararr1.Length; i++)
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


        /// <summary>
        /// Prints the prime number in 2d array.
        /// after 0 no elements get printed.
        /// </summary>
        /// <param name="PrimeArray">The prime array.</param>
        public static void PrintPrimeNumberIn2D(int[][] Array)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (Array[i][j] != 0)
                    {
                        Console.Write(" {0}",Array[i][j]);
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(" ");
            }

           

        }










    }//close class util

    }//close Utility namespace

