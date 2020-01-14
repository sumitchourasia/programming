using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inventory_Management
{
   public class InventoryManager
    {
        /// <summary>
        /// Managers this instance.
        /// </summary>
        public void InventoryManagerMethod(InventoryItems inventoryItemsObject)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("enter your choice");
                Console.WriteLine("1.  Adding  rice");
                Console.WriteLine("2.  Adding wheat");
                Console.WriteLine("3.  Adding pulses");
                Console.WriteLine("4.  Remove Rice item ");
                Console.WriteLine("5.  Remove an item ");
                Console.WriteLine("6.  Update an item");
                Console.WriteLine(" -1. exit");

                choice = Utility.ReadInt();

                switch (choice)
                {
                    case 1:
                        Utility.AddRice(inventoryItemsObject);
                        break;

                    case 2:
                        Utility.AddWheat(inventoryItemsObject);
                        break;

                    case 3:
                        Utility.AddPulses(inventoryItemsObject);
                        break;

                    case 4:
                        Utility.RemoveRice(inventoryItemsObject);
                        break;
                    
                    case 5:
                        Utility.Remove(inventoryItemsObject);
                        break;

                    case 6:
                        Utility.Update(inventoryItemsObject);
                        break;
                        
                    case -1:
                        return;

                    default:
                        Console.WriteLine("Enter the proper choice");
                        break;
                }
                Utility.PrintInventoryItem(inventoryItemsObject);
                }while (choice != -1);                   
        }
    }
}
