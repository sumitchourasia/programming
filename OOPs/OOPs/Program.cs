using OOPs.Inventory_Details;
using System;

namespace OOPs
{
    /// <summary>
    /// program class to run all the programs of OOPs section
    /// </summary>
    class Program
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
                Console.WriteLine(" enter your choice");
                Console.WriteLine(" 1 -> Address Book");
                Console.WriteLine(" 2 -> Inventory Details");
                Console.WriteLine(" 3 -> Inventory management programs");
                Console.WriteLine(" 4 -> Stock Account Management ");
                Console.WriteLine(" 5 -> Commercial Data Processing ");
                Console.WriteLine(" 9 -> DeckOfCards ");
                Console.WriteLine("10 -> DeckOfCardsExtendedUsingQueue");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddressBook.AddressBookGUI addressBookGUIObject = new AddressBook.AddressBookGUI();
                        addressBookGUIObject.AddressBookGUIMethod();
                        break;
                    case 2:
                        Json_Inventory_Data_Mangement obj = new Json_Inventory_Data_Mangement();
                        obj.Json_Inventory_Data_Mangement_Method();
                        break;
                    case 3:
                        Inventory_Management.InventoryManagementDriver inventoymanagementobject = new Inventory_Management.InventoryManagementDriver();
                        inventoymanagementobject.InventoryManagementDriverMethod();
                        break;
                    case 4:
                        StockAccountManagement.Stocks stockObject = new StockAccountManagement.Stocks();
                        stockObject.StocksMethod();
                        break;
                    case 5:
                        CommercialDataProcessing.DataProcessing dataProcessingObject = new CommercialDataProcessing.DataProcessing();
                        dataProcessingObject.DataProcessingMethod();
                        break;
                    case 9:
                        DeckOfCards.DeckOfCards deckOfCardsObject = new DeckOfCards.DeckOfCards();
                        deckOfCardsObject.DeckOfCardsMethods();
                        break;
                    case 10:
                        DeckOfCardsExtendedToQueue.DeckOfCardExtendedQueue playerObject = new DeckOfCardsExtendedToQueue.DeckOfCardExtendedQueue();
                        playerObject.DeckOfCardExtendedQueueMethod();
                        break;
                }
        }
    }
}
