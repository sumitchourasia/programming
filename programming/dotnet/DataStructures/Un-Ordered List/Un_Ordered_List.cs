﻿using System;
using System.IO;

namespace DataStructures.Un_Ordered_List
{
    class Un_Ordered_List<T>
    {
       public static int count = 0;
       public ListNode<T> Head = null;
        public void Un_Ordered_ListMethod()
        {
            string path = @"C:\Users\Bridgelabz\Desktop\bridgelabz\programming\dotnet\DataStructures\Un-Ordered List\Un_Ordered.txt";

            T[] array = new T[50];

            ////store file text into array
            Utility.ReadFileIntoArray(path, array);

            Utility.PrintArray(array);

            Console.WriteLine(" ");

            ListNode<T> Head = null;

            ////convert the array to linked list
            Head = Utility.ArrayToLinkedList(Head, array);

            ////print linked list
            Utility.PrintLinkedList(Head);

            Console.WriteLine(" ");

            Console.WriteLine("enter the item to search");
            ////take the user input to search into linkedlist.
            String item = Utility.ReadString();
           
            ListNode<T> newnode = new ListNode<T>();
            newnode.data = (T)((object)item);

            ////search the item in list
            bool found = Utility.SearchItem(Head,item);

            Console.WriteLine(found);

            if(!found)
            {
                Head = Utility.Add(Head,newnode);
            }
            else
            {
                int index = Utility.Index(Head, newnode);
                Console.WriteLine(" index is : "+index);
                ListNode<T> data =Utility.Pop(ref Head,index);
                Console.WriteLine("popped data is : {0} ",data.data);
            }

            Console.WriteLine(" list to store in file is : ");
            Utility.PrintLinkedList(Head);

            Utility.LinkedListToFile<T>(Head,path);
            
        }
    }
}
