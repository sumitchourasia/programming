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
            string proceed = " ";
            do
            {
                Console.WriteLine("enter your choice");
                Console.WriteLine("1.  adding  rice");
                Console.WriteLine("2.  adding wheat");
                Console.WriteLine("3.  adding pulses");
                Console.WriteLine("4.  deleting rice");
                Console.WriteLine("5.  deleting wheat");
                Console.WriteLine("6.  deleting pulses");
                Console.WriteLine("7.  Updating rice");
                Console.WriteLine("8.  Updating wheat");
                Console.WriteLine("9.  Updating pulses");
                Console.WriteLine("10. viewing details");
                Console.WriteLine(" -1. exit");

                choice = Utility.ReadInt();

                switch (choice)
                {
                    case 1:
                        Utility.AddRice(inventoryItemsObject);
                        Utility.PrintInventoryItem(inventoryItemsObject);
                        break;

                    case 2:
                            Utility.AddWheat(inventoryItemsObject);
                        break;

                    case 3:
                            Utility.AddPulses(inventoryItemsObject);
                        break;

                    case 4:
                            Utility.RemoveRice(inventoryItemsObject);
                            Utility.PrintInventoryItem(inventoryItemsObject);
                            break;
                /*
                    case 5:
                            Utility.RemoveWheat();
                        break;

                    case 6:
                            Utility.DeletePulse();
                        break;
                */
                    case 7:
                            Utility.UpdateRice();
                        break;

                    case 8:
                            Utility.UpdateWheat();
                        break;

                    case 9:
                        Utility.UpdatePulses();
                        break;

                    case 10:
                        Utility.ViewDetails();
                        break;
                    
                    case -1:
                        return;

                    default:
                        Console.WriteLine("Enter the proper number");
                        break;
                }
                Console.Write("do you eant to continue  yes/no:");
                proceed = Utility.ReadString();
                }while (proceed != "no");                   
        }
    }
}
