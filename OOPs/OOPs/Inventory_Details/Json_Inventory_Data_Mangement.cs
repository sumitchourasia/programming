using System;

namespace OOPs.Inventory_Details
{
    /// <summary>
    /// Inventory Data management 
    /// </summary>
    public class Json_Inventory_Data_Mangement
    {
        /// <summary>
        /// the inventory data mangement method to execute all the operation.
        /// </summary>
        public void Json_Inventory_Data_Mangement_Method ()
        {
            try
            {
                string path = @"C:/Users/Bridgelabz/Documents/GitHub/programming/OOP's/OOPs/OOPs/Inventory_Details/InventoryDetailsFIle.json";
                string StringOfJson = Utility.ReadFile(path);
                Console.WriteLine(StringOfJson + "string of json");
                InventoryItem fileList = Utility.DeserializeTheObject(StringOfJson);
                Utility.PrintInventoryItem(fileList);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
