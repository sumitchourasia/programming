using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class contains all the static method. 
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
            StreamReader streamReaderObject = new StreamReader(path);
            string jsonstring = streamReaderObject.ReadToEnd();
            return jsonstring;
        }

        /// <summary>
        /// Deserializes the specified jsonstring.
        /// </summary>
        /// <param name="jsonstring">The jsonstring.</param>
        /// <returns></returns>
        public static MemberStockPortfolio Deserialize(string jsonstring)
        {
            MemberStockPortfolio memberStockPortfolioObject = null;
            try
            {
                memberStockPortfolioObject = JsonConvert.DeserializeObject<MemberStockPortfolio>(jsonstring);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return memberStockPortfolioObject;
        }

        /// <summary>
        /// Prints the member stock.
        /// </summary>
        /// <param name="memberStockObject">The member stock object.</param>
        public static void PrintMemberStock(MemberStockPortfolio memberStockObject)
        {
            double totalValue = 0;
            IList<MemberStockData> stocklist = memberStockObject.memberStockList;
            Console.WriteLine("ShareName \t NumberOfShare \t SharePrice \t TotalSharePrice  ");
            foreach (var stock in stocklist)
            {
                totalValue += (stock.NumberOfShare * stock.SharePrice);
                Console.WriteLine(stock.ShareName + " \t\t" + stock.NumberOfShare + "\t\t " + stock.SharePrice + " \t\t" + stock.NumberOfShare * stock.SharePrice);
            }
            Console.WriteLine("total value of all the share : " + totalValue);
        }

        /// <summary>
        /// Creates the linked list of type company.
        /// </summary>
        /// <returns></returns>
        public static ListNodeCompany CreateLinkedList()
        {
            ListNodeCompany head = null;
            return head;
        }

        /// <summary>
        /// Creates the list node of type company.
        /// </summary>
        /// <returns></returns>
        public static ListNodeCompany CreateListNodeCompany()
        {
            ListNodeCompany newNode = new ListNodeCompany();
            return newNode;
        }

        public static bool CheckShareAvailable(ListNodeCompany head, string shareName , int numberOfShare)
        {
            return false;
        }

        ////readfile()
        ////deserializeObject()
        //// methods for linkedlist operation
        ////methods for operation for queue using linked list
        ////methods for operation for stack using linked list
    }
}
