using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

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
        /// Reads the double.
        /// </summary>
        /// <returns></returns>
        public static double ReadDouble()
        {
            double input = 0.0;
            bool success = false;
            while(true)
            {
                try
                {
                    success = double.TryParse(Console.ReadLine(), out input);
                    if (success)
                        return input;
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid format try again!!!");
                }
               
            }
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
        {
            return Console.ReadLine();
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

        /// <summary>
        /// Adds the rice.
        /// </summary>
        /// <param name="inventoryItemsObject">The inventory items object.</param>
        public static void AddRice(InventoryItems inventoryItemsObject)
        {
            List<ItemsData> rices = inventoryItemsObject.Rice;
            ItemsData newRice = new ItemsData();
            Console.Write("enter the name : ");
            newRice.Name = ReadString();
            Console.Write("enter the weight : ");
            newRice.Weight = ReadDouble();
            Console.Write("enter the price");
            newRice.Price = ReadDouble();
            rices.Add(newRice);
            inventoryItemsObject.Rice = rices;
        }

        /// <summary>
        /// Adds the wheat.
        /// </summary>
        /// <param name="inventoryItemsObject">The inventory items object.</param>
        public static void AddWheat(InventoryItems inventoryItemsObject)
        {
            List<ItemsData> wheat = inventoryItemsObject.Wheat;
            ItemsData newWheat = new ItemsData();
            Console.Write("enter the name :");
            newWheat.Name = ReadString();
            Console.Write("enter the weight :");
            newWheat.Weight = ReadDouble();
            Console.Write("enter the price :");
            newWheat.Price = ReadDouble();
            ////adding new wheat item to the wheat list
            wheat.Add(newWheat);
            ////adding the updated wheat list 
            inventoryItemsObject.Wheat = wheat;
        }

        /// <summary>
        /// Adds the pulses.
        /// </summary>
        /// <param name="inventoryItemsObject">The inventory items object.</param>
        public static void AddPulses(InventoryItems inventoryItemsObject)
        {
            List<ItemsData> pulses = inventoryItemsObject.Pulses;
            ItemsData newPulses = new ItemsData();
            Console.Write("enter the name :");
            newPulses.Name = ReadString();
            Console.Write("enter the weight :");
            newPulses.Weight = ReadDouble();
            Console.Write("enter the price");
            newPulses.Price = ReadDouble();
            pulses.Add(newPulses);
            inventoryItemsObject.Pulses = pulses;
        }

        /// <summary>
        /// Removes the rice.
        /// </summary>
        /// <param name="inventoryItemsObject">The inventory items object.</param>
        public static void RemoveRice(InventoryItems inventoryItemsObject)
        {
            List<ItemsData> rices = inventoryItemsObject.Rice;
            Console.Write("Enter the name of the rice item to delete : ");
            string removeRice = ReadString();
            foreach(var item in rices)
            {
                Console.WriteLine("inside foreach loop");
                if (item.Name == removeRice)
                {
                    rices.Remove(item);
                    break;
                }
            }
            inventoryItemsObject.Rice = rices;
        }

        /// <summary>
        /// Removes the specified inventory items object.
        /// </summary>
        /// <param name="inventoryItemsObject">The inventory items object.</param>
        public static void Remove(InventoryItems inventoryItemsObject)
        {
            List<ItemsData>[] listOfItems = new List<ItemsData>[3];
            listOfItems[0] = inventoryItemsObject.Rice;
            listOfItems[1] = inventoryItemsObject.Wheat;
            listOfItems[2] = inventoryItemsObject.Pulses;

            Console.Write("enter the name of item to remove : ");
            string removeNameItem = ReadString();
            foreach(var items in listOfItems)
            {
                foreach(var item in items)
                {
                    if(item.Name == removeNameItem)
                    {
                        items.Remove(item);
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Updates the specified inventory items object.
        /// </summary>
        /// <param name="inventoryItemsObject">The inventory items object.</param>
        public static void Update(InventoryItems inventoryItemsObject)
        {
            Console.WriteLine("inside update method");
            List<ItemsData>[] listOfItems = new List<ItemsData>[3];
            listOfItems[0] = inventoryItemsObject.Rice;
            listOfItems[1] = inventoryItemsObject.Wheat;
            listOfItems[2] = inventoryItemsObject.Pulses;

            Console.Write("enter the name of item to update : ");

            string removeNameItem = ReadString();
            foreach (var items in listOfItems)
            {
                foreach (var item in items)
                {
                    if (item.Name == removeNameItem)
                    {
                        Console.WriteLine("enter the property to update : ");
                        string property = ReadString();
                       
                        if(property == "Name")
                        {
                            Console.Write("enter new Name");
                            string newName = ReadString();
                            item.Name = newName;
                            return;
                        }
                        else if(property == "Weight")
                        {
                            Console.Write("enter new Weight");
                            double newWeight = ReadDouble();
                            item.Weight = newWeight;
                            return;
                        }
                        else if(property == "Price")
                        {
                            Console.Write("enter new price");
                            double newPrice = ReadDouble();
                            item.Price = newPrice;
                            return;
                        }
                    }
                }
            }
        }


        
    }
}
