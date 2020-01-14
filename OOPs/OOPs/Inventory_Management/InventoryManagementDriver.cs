using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inventory_Management
{
    public class InventoryManagementDriver
    {
        public void InventoryManagementDriverMethod()
        {
            try
            {
                string path = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\Inventory_Management\InventoryItemsFile.json";

                string StringOfJson = Utility.ReadFile(path);

             //   Console.WriteLine(StringOfJson + "string of json");

                InventoryItems fileList = Utility.DeserializeTheObject(StringOfJson);

                Utility.PrintInventoryItem(fileList);

                InventoryManager inventoryManager = new InventoryManager();
                inventoryManager.InventoryManagerMethod(fileList);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
