using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OOPs.StockAccountManagement
{
    /// <summary>
    /// Utility class to contain all the static methods
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static string ReadFile(string path)
        {
            string jsoninstring = string.Empty;
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(path);
                jsoninstring = streamReader.ReadToEnd();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            streamReader.Close();
            return jsoninstring;
        }

        /// <summary>
        /// Deserialises the object.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public static StockPortfolio DeserialiseTheObject(string jsonInString)
        {
            StockPortfolio stockObject = null;
            try
            {
                stockObject = JsonConvert.DeserializeObject<StockPortfolio>(jsonInString);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return stockObject;
        }

        /// <summary>
        /// Prints the stock.
        /// </summary>
        /// <param name="stocks">The stocks.</param>
        public static void PrintStock(StockPortfolio stocks)
        {
           
               List<StockData> list = stocks.MemberStocks;

            Console.WriteLine("ShareName \t NumberOfShare \t SharePrice " );
            if (stocks != null)
            {
                foreach (var stock in list)
                {

                    Console.WriteLine(stock.ShareName + "\t" + "\t" + stock.NumberOfShares + "\t\t" + "\t" + stock.SharePrice);

                }
            }
        }
    }
}
