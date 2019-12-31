using System;

namespace Utility
{
    public static class Util
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
        /// Prints the one dimensional array.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}", arr[i]);
                if ((i + 1) % 4 == 0)
                {
                    Console.Write(" ");
                }
            }
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
            return ;
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




    }//close class util

}//close Utility namespace

