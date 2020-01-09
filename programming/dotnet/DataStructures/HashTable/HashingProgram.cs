using System;
using System.IO;

namespace DataStructures.HashTable
{
    public class HashingProgram<T>
    {
        public void HashingMethod()
        {
            ListNode<T>[] HashTable = Utility.CreateHashTableUsingLinkedList<T>();
            string path = @"C:\Users\Bridgelabz\Desktop\bridgelabz\programming\dotnet\DataStructures\HashTable\HashDataFile.txt";
            //// int choice = 0;
            int lineCount = File.ReadAllLines(path).Length;

            T[] Array = new T[50];

            Utility.ReadFileIntoArray(path,Array);

            Utility.PrintArray(Array);

            for(int i=0;i<Array.Length;i++)
            {
                if (Array[i] != null)
                {
                    if (!Utility.SearchIntoHashTable(HashTable, Array[i]))
                    {
                        Utility.InsertIntoHashTable(HashTable, Array[i]);
                    }
                    else
                    {
                        Utility.DeleteFromHashTable(HashTable, Array[i]);
                    }
                }
                else
                {
                    break;
                }
            }

            for(int i=0;i<11;i++)
            {
                Utility.PrintLinkedList(HashTable[i]);
            }

            Utility.HashTableToFile(HashTable,path);

        }

        }
}
