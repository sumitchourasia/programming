using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using OOPs.Inventory_Details;

namespace OOPs.Inventory_Management
{
    public static class Utility
    {
        private static object streamReader;

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
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            string fileToString = null;
            StreamReader streamreader = null;
            try
            {
                streamreader = new StreamReader(path);
                fileToString = streamreader.ReadToEnd();
                streamreader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception while reading the file");
                Console.WriteLine(e.Message);
            }

            return fileToString;
        }


        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <param name="JsonInString">The json in string.</param>
        /// <returns></returns>
        public static InventoryItems DeserializeTheObject(string JsonInString)
        {
            InventoryItems fileList = null;
            try
            {
                fileList = JsonConvert.DeserializeObject<InventoryItems>(JsonInString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return fileList;
        }


        /// <summary>
        /// Prints the inventory item.
        /// </summary>
        /// <param name="fileList">The file list.</param>
        public static void PrintInventoryItem(InventoryItems fileList)
        {
            List<ItemsData>[] items = new List<ItemsData>[3];

            items[0] = fileList.Rice;
            items[1] = fileList.Wheat;
            items[2] = fileList.Pulses;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Name \t\t" + "Price \t" + "   " + "Weight \t" + "TotalPrice");

            foreach (var data in items)
            {
                foreach (var item in data)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t\t" + item.Weight + "\t\t" + (item.Price * item.Weight));
                }
            }
        }

    }
}
