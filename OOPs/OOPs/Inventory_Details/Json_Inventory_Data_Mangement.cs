using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace OOPs.Inventory_Details
{
    public class Json_Inventory_Data_Mangement
    {
        public void Json_Inventory_Data_Mangement_Method ()
        {
            string path = @"C: \Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\Inventory_Details\InventoryDetailsFIle.json";
            string StringOfJson = Utility.ReadFile(path);

            InventoryItem FileList = Utility.DeserializeTheObject(StringOfJson);

           

            //// Stores the data in the list
            IList<InventoryData> rice = FileList.Rice;
            Console.WriteLine("Types of Rice");
            Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
            double priceOfRice = 0;

            //// Loops over the rice object
            foreach (var item in rice)
            {
                Console.WriteLine(item.Name + "   " + item.PricePerKg + "      " + item.Weight);
                priceOfRice = priceOfRice + (item.PricePerKg * item.Weight);
            }

            //// Prints the total price of the rice
            Console.WriteLine("Total price of rice is " + priceOfRice);
            Console.WriteLine();

            ///// Stores the data in list
            IList<InventoryData> wheat = FileList.Wheat;
            Console.WriteLine("Types of Wheat");
            Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
            double priceOfWheat = 0;

            //// loops over the wheat object
            foreach (var item in wheat)
            {
                Console.WriteLine(item.Name + "   " + item.PricePerKg + "      " + item.Weight);
                priceOfWheat = priceOfWheat + (item.PricePerKg * item.Weight);
            }

            //// Prints the price of wheat
            Console.WriteLine("Total price of wheat is " + priceOfWheat);
            Console.WriteLine();

            //// Store the pulses in the list
            IList<InventoryData> pulses = FileList.Pulses;
            Console.WriteLine("Types of Pulses");
            Console.WriteLine("Name" + "   " + "Price" + "   " + "Weight");
            double priceOfPulses = 0;

            //// Loops over the pulses object
            foreach (var item in pulses)
            {
                Console.WriteLine(item.Name + "   " + item.PricePerKg + "      " + item.Weight);
                priceOfPulses = priceOfPulses + (item.PricePerKg * item.Weight);
            }

            //// Prints the price of the pulses
            Console.WriteLine("Total price of pulses is " + priceOfPulses);
            Console.WriteLine();


        }
    }

}
