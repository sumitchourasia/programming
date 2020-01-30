using System;

namespace OOPs.Inventory_Management
{
    /// <summary>
    /// invntory management driver class
    /// </summary>
    public class InventoryManagementDriver
    {
        /// <summary>
        /// Inventory management driver method.
        /// </summary>
        public void InventoryManagementDriverMethod()
        {
            try
            {
                string path = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\Inventory_Management\InventoryItemsFile.json";
                string StringOfJson = Utility.ReadFile(path);
                // Console.WriteLine(StringOfJson + "string of json");
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
