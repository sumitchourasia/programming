using System;
using System.IO;


namespace DataStructures
{
    class StreamWriterAndReader
    {
        public void streamReadWriteMethod()
        {
            string[] RArray = new string[5];
            string path = @"C:\Users\Bridgelabz\Desktop\Demo.txt";
            string[] array = new string[5];
            if (File.Exists(path))
                Console.WriteLine("exits");
            Console.WriteLine("enter 5 strings");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Utility.ReadString();
            }


            StreamWriter SW = new StreamWriter(path);

            Console.WriteLine("writing to file");
            for(int i=0;i<5;i++)
            {
                SW.WriteLine(array[i]);
            }

            SW.Close();

            StreamReader SR = new StreamReader(path);
            for (int i=0;i<5;i++)
            {
                RArray[i] = SR.ReadLine();
            }

            Console.WriteLine("read the strings from the file.");

            Utility.PrintStringArray(RArray);
            SR.Close();

        }

    }
}
