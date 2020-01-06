using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace DataStructures
{
       
    public static class Utility
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



        public static Boolean CanCovert(String value, Type type)
        {
            TypeConverter converter = TypeDescriptor.GetConverter(type);
            return converter.IsValid(value);
        }



        public static void PrintArray<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    Console.Write("  {0}", array[i]);
                }
            }
        }



        public static void ReadFileIntoArray<T>(string path, T[] array)
        {
            StreamReader SR = new StreamReader(path);

            for (int i = 0; i < array.Length; i++)
            {
                string data = SR.ReadLine();
                if (data != null)
                    array[i] = (T)(object)data;
                else
                    break;
            }

            SR.Close();
        }

       



        public static ListNode<T> ArrayToLinkedList<T>(ListNode<T> head, T[] array)
        {
            ListNode<T> newnode = null;
            string data;
            for (int i = 0; i < array.Length; i++)
            {
                data =  (string)((object)array[i]);
                if (data != null)
                {
                    newnode = new ListNode<T>();
                    newnode.data = (T)((object)data);
                    head = Add(head, newnode);
                }
                else
                {
                    break;
                }
            }
            return head;
        }


            public static ListNode<T> ArrayToOrderedLinkedList<T>(ListNode<T> head, T[] array)
            {
                    ListNode<T> newnode = null;
                    string data;
                    for (int i = 0; i < array.Length; i++)
                    {
                        data = (string)((object)array[i]);
                        if (data != null)
                        {
                            newnode = new ListNode<T>();
                            newnode.data = (T)((object)data);
                            head = AddInOrder(head, newnode);
                        }
                        else
                        {
                            break;
                        }
                    }
                    return head;
             }

        public static void LinkedListToFile<T>(ListNode<T> head, string path)
        {
            StreamWriter SW = new StreamWriter(path);

            if (head == null || !File.Exists(path))
            {
                Console.WriteLine("head is null or file doesnot exist");
            }
            else
            {
                ListNode<T> temp = head;

                while (temp != null)
                {
                    SW.WriteLine((string)((object)temp.data), true);
                    temp = temp.next;
                }
            }
            SW.Close();
        }




        public static ListNode<T> Add<T>( ListNode<T> head , ListNode<T> newnode)
        {
            ListNode<T> temp ;

            if (head == null)
            {
                head = newnode;
               
            }
            else
            {
                temp = head;
               
                while(temp.next!=null)
                {
                    temp = temp.next;
                }

                temp.next = newnode;
            }
            return head;
        }

        /*
         *  if (head == null)
            {
                head = newnode;
                return head;
            }

            int newdata = 0;
            int data = 0;
            ListNode<T> temp = head;
            newdata = Convert.ToInt32(newnode.data);
            data = Convert.ToInt32(head.data);

            if (newdata < data)
            {
                newnode.next = head;
                head = newnode;
                return head;
            }
            else
            {
                temp = head;
                newdata = Convert.ToInt32(newnode.data);
                data = Convert.ToInt32(temp.data);
              
                while (temp.next != null)
                {
                  
                    data = Convert.ToInt32(temp.data);

                    if (newdata < data)
                    {
                        newnode.next = temp.next;
                        temp = newnode;
                        break;
                    }
                    
                    temp = temp.next;
                }

                if (temp.next == null)
                {
                    temp.next = newnode;
                }


            }
            return head;

         * 
         * 
         * 
         * 
         * 
         * */




        /// <summary>
        /// Adds the new node in ascending order in the linked list.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="head">The head.</param>
        /// <param name="newnode">The newnode.</param>
        /// <returns></returns>
        public static ListNode<T> AddInOrder<T>(ListNode<T> head, ListNode<T> newnode)
        {
            if(head == null)
            {
                head = newnode;
            }
            else
            {
                ListNode<T> temp = head;
                if(Convert.ToInt32(head.data)>Convert.ToInt32(newnode.data))
                {
                    newnode.next = head;
                    head = newnode;
                }
                else
                {
                    temp = head;
                    while(temp.next != null)
                    {
                        if(Convert.ToInt32(temp.next.data) > Convert.ToInt32(newnode.data))
                        {
                            newnode.next = temp.next;
                            temp.next = newnode;
                            break;
                        }
                        temp = temp.next;
                    }
                    temp.next = newnode;
                }

            }
            return head;
        }


        public static void PrintLinkedList<T>(ListNode<T> head)
        {
            Console.WriteLine(" print linked list :");
            if(head == null)
            {
                
                Console.WriteLine("empty linked list");
            }
            else
            {
                ListNode<T> temp = head;
                while(temp!=null)
                {
                    Console.Write(" "+temp.data);
                    temp = temp.next;
                }
            }
        }



        /// <summary>
        /// to search the item into the linkedlist and return true or false.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool SearchItem<T>(ListNode<T> head, string item)
        {
            if (head == null)
            {
                return false;
            }
            else if (head.data.Equals(item))
            {
                return true;
            }
            else 
            { 
                ListNode<T> temp = head;
                while (temp != null)
                {
                    if ((temp.data).Equals(item))
                    {
                        return true;
                    }
                    temp = temp.next;
                }
            }

            return false;
        }




        /// <summary>
        /// if the item is found then the return the index otherwise return -1;
        /// </summary>
        /// <param name="head"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static int Index<T>(ListNode<T> head, ListNode<T> item)
        {
            int index = -1;

            if (head == null)
            {
                return index;
            }
            else
            {
                index = 0;
                ListNode<T> temp = head;
                while (temp != null)
                {
                    if ((temp.data).Equals(item.data))
                    {
                        return index;
                    }
                    index++;
                    temp = temp.next;
                }
            }
            return index;
        }


        /// <summary>
        /// calculate the size of linked list
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int ListSize<T>(ListNode<T> head)
        {
            int size = -1;

            if (head == null)
            {
                size = 1;
                return size;
            }
            else
            {
                ListNode<T> temp = head;

                while (temp != null)
                {
                    size++;
                    temp = temp.next;
                }

            }

            return size;
        }




        public static ListNode<T> Pop<T>(ref ListNode<T> head, int index)
        {
            ListNode<T> temp;
            ListNode<T> item;
            ref ListNode<T> refhead = ref head;
            int size = Utility.ListSize(head);

            if (head == null)
            {
                return null;
            }
            else if(index == 0)
            {
                item = head;
                refhead = head.next;
                return item;
            }
            else
            {
                temp = head;
                for (int i = 0; i < index - 1; i++)
                {
                    temp = temp.next;
                }
                item = temp.next;
                if (temp.next.next == null)
                {
                    temp.next = null;
                }
                else
                {
                    temp.next = temp.next.next;
                }

            }

            return item; 
        }














        /// <summary>
        /// Reads the double.
        /// method to read double from keyboard and return it
        /// </summary>
        /// <returns>
        /// double value
        /// </returns>
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
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("  {0}", array[i]);
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
                    intarr[i] = Utility.ReadInt();
                }

            }


            /// <summary>
            /// this method takes string array as parameter and Inputs the string array.
            /// </summary>
            /// <param name="array">The array.</param>
            public static void InputStringArray(String[] array)
            {
                for (int i = 0; i < array.Length; i++)
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
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("enter the data : ");
                    data = ReadInt();
                    for (int j = 0; j <= i; j++)
                    {
                        if (arr[j] == data)
                        {
                            i--;
                            IsPresent = true;
                            Console.WriteLine(" already present");
                            break;
                        }
                    }
                    if (IsPresent == false)
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
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        intarr[i, j] = Utility.ReadInt();
                    }
                }
                return;
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
                return;
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
                return;
            }


            /// <summary>
            /// Prints the two dimensional integer array.
            /// </summary>
            /// <param name="intarr">two dimensional integer array</param>
            public static void PrintTwoDIntArray(int[,] intarr)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(intarr[i, j]);
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
                double t = (double)c;

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
        /// this method accepts a generics array of type int. and sort the passed array in ascending order.
        /// </summary>
        /// <param name="arr">The arr.</param>
        public static void DoBubbleSort<T>(T[] arr)
        {
            T temp;

            //loop through the array.
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //if condition satisfies then swap the elements.
                    int newdata = 0;
                    bool nsuccess = Int32.TryParse((string)((object)arr[j]),out newdata);
                    int data = 0;
                    bool success = Int32.TryParse((string)((object)arr[j+1]),out data);
                    if (success && nsuccess)
                    {
                        if (data >= newdata)
                        {
                            temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
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
                            Console.Write(" {0}", Array[i][j]);
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
