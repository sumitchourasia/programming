using System;
using System.Collections.Generic;
using System.Text;
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
                Utility.PrintLinkedList(Head);
            }
            else
            {
               Console.WriteLine(Utility.Index(Head,newnode));
                //Pop(newnode);
            }
        }











        public static ListNode<T> Pop(ListNode<T> head,ListNode<T> node)
        {
            if(head == null)
            {
                return null;
            }
            return null;
        }


    }
}
