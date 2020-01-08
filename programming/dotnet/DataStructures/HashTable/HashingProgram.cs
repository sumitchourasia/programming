using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace DataStructures.HashTable
{
    public class HashingProgram<T>
    {
        public void HashingMethod()
        {
            ListNode<T>[] HashTable = CreateHashTableUsingLinkedList();
            string path = @"C:\Users\Bridgelabz\Desktop\bridgelabz\programming\dotnet\DataStructures\HashTable\HashDataFile.txt";
            //// int choice = 0;
            int lineCount = File.ReadAllLines(path).Length;

            T[] Array = new T[lineCount];

            Utility.ReadFileIntoArray(path,Array);

            Utility.PrintArray(Array);

            for(int i=0;i<Array.Length;i++)
            {
               if( ! SearchIntoHashTable(HashTable, Array[i]))
                {
                    InsertIntoHashTable(HashTable, Array[i]);
                }
               else
                {
                    DeleteFromHashTable(HashTable,Array[i]);
                }
            }

            for(int i=0;i<11;i++)
            {
                Utility.PrintLinkedList(HashTable[i]);
            }

            HashTableToFile(HashTable,path);

        }

        public ListNode<T>[] CreateHashTableUsingLinkedList( )
        {
            ListNode<T>[] HashTable = new ListNode<T>[11];

            return HashTable;
        }


        public void InsertIntoHashTable(ListNode<T>[] HashTable ,T item)
        {
            int index = 0;
            ListNode<T> newnode = new ListNode<T>();
            newnode.data =(T)((object)item);

            index = HashingFunction(HashTable,item);
            
            HashTable[index] = Utility.AddInOrder(HashTable[index] , newnode);

            Console.WriteLine(" " );

        }

        public void DeleteFromHashTable(ListNode<T>[] HashTable , T item)
        {
            int index = 0;
            int innerindex = 0;
            index = HashingFunction(HashTable , item);

            innerindex = Utility.Index(HashTable[index] , (ListNode<T>)((object)item));

            ListNode<T> data = Utility.Pop(ref HashTable[index] , innerindex);

        }
       

        public bool SearchIntoHashTable(ListNode<T>[] hashtable , T item)
        {
            int index = HashingFunction(hashtable,item);

            return Utility.SearchItem(hashtable[index] , (string)((object)item)) ;
        }

        public int HashingFunction(ListNode<T>[] HashTable, T item)
        {
            int data = Convert.ToInt32(item);
           
            return (data % HashTable.Length);
        }

        public void HashTableToFile(ListNode<T>[] HashTable, string path)
        {
            StreamWriter SW = new StreamWriter(path);

            for (int i = 0; i < HashTable.Length; i++)
            {

                if (HashTable[i] != null || !File.Exists(path))
                {
                    ListNode<T> temp = HashTable[i];

                    while (temp != null)
                    {
                        string data = (string)((object)temp.data);
                        Console.WriteLine("data to be written : {0}", data);
                        SW.Write(data, true);
                        SW.Write("   ", true);
                        temp = temp.next;
                    }
                    SW.WriteLine(" ", true);
                }

            }
            SW.Close();
        }
        }
}
