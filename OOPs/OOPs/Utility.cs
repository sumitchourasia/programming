using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using OOPs.Inventory_Details;

namespace OOPs
{
   public static class Utility
    {

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            string FileToString = null;
            StreamReader streamreader = null;
            try
            {
                streamreader = new StreamReader(path);
                FileToString = streamreader.ReadToEnd();
                streamreader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
           
            return FileToString;
        }


        /// <summary>
        /// Deserializes the object.
        /// </summary>
        /// <param name="JsonInString">The json in string.</param>
        /// <returns></returns>
        public static InventoryItem DeserializeTheObject(string JsonInString)
        {
           InventoryItem? FileList = JsonConvert.DeserializeObject<InventoryItem>(JsonInString);

            return FileList;
        }
    }
}
