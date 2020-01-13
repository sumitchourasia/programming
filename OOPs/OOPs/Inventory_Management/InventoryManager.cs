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
        public void InventoryManagerMethod()
        {
                    do
                    {
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

                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Utility.AddRice();
                                break;

                            case 2:
                                 Utility.AddWheat();
                                break;

                            case 3:
                                 Utility.AddPulses();
                                break;

                            case 4:
                                 Utility.DeleteRice();
                                break;

                            case 5:
                                 Utility.DeleteWheat();
                                break;

                            case 6:
                                 Utility.DeletePulse();
                                break;

                            case 7:
                                 Utility.Update();
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

                            default:
                                Console.WriteLine("Enter the proper number");
                                break;
                        }
                    }
                    while (character != 'n');

        }
    }
}
