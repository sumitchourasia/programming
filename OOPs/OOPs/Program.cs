using OOPs.Inventory_Details;
using System;

namespace OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter your choice");
            Console.WriteLine(" 2 -> Inventory Details");
            int choice =  Convert.ToInt32( Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Json_Inventory_Data_Mangement obj = new Json_Inventory_Data_Mangement();
                    obj.Json_Inventory_Data_Mangement_Method();
                    break;
            }

        }
    }
}
