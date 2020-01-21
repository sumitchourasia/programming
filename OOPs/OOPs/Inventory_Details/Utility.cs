using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using OOPs.Inventory_Details;

namespace OOPs
{
    /// <summary>
    /// Utility class contains the utility static methods for inventory management program
    /// </summary>
    public static class Utility
    {
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
        public static InventoryItem DeserializeTheObject(string JsonInString)
        {
            InventoryItem fileList = null;
            try
            {
                fileList = JsonConvert.DeserializeObject<InventoryItem>(JsonInString);
            }
            catch(Exception e)
            {
                Console.WriteLine("exception while deserializing");
                Console.WriteLine(e.Message);
            }
            return fileList;
        }
                
        /// <summary>
        /// Prints the inventory item.
        /// </summary>
        /// <param name="fileList">The file list.</param>
        public static void PrintInventoryItem(InventoryItem fileList)
        {
            ////declare initialize and assign inventory items to List<T> array.
            List<InventoryItemData>[] items = new List<InventoryItemData>[3];
            items[0] = fileList.Rice;
            items[1] = fileList.Wheat;
            items[2] = fileList.Pulses;
           
            Console.WriteLine();
            //// set the format
            Console.WriteLine("Name \t\t" + "Price \t" + "   " + "Weight \t" +"TotalPrice");

            ////loop thorugh the entire List<>[]array for each different types of items.
            foreach (var data in items)
                foreach(var item in data)
                    Console.WriteLine(item.Name + "\t" + item.PricePerKg + "\t\t" + item.Weight + "\t\t" + (item.PricePerKg * item.Weight));
        }
    }
}
