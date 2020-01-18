﻿using System;
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
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
        {
            string input = Console.ReadLine();
            return input;
        }

        /// <summary>
        /// Reads the int.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            int input = 0;
            bool success = false;
            while (true)
            {
                try
                {
                    success = int.TryParse(Console.ReadLine() , out input);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if(success == true)
                {
                    return input;
                }
            }
        }


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

        /// <summary>
        /// Checks the share available in member stock object.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <param name="numberOfShare">The number of share.</param>
        /// <returns></returns>
        public static bool CheckShareAvailableInMemberStockObject(ListNodeCompany head, string shareName , int numberOfShare)
        {
            return false;
        }

        /// <summary>
        /// Checks the share available in linked list company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <param name="numberOfShare">The number of share.</param>
        /// <returns></returns>
        public static ListNodeCompany CheckShareAvailableInLinkedListCompany(ListNodeCompany head ,string shareName , int numberOfShare )
        {
            ListNodeCompany listNodecompany = null;

            return listNodecompany;
        }

        /// <summary>
        /// Checks the share name is in linked list company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <returns></returns>
        public static bool CheckShareNameIsInLinkedListCompany(ListNodeCompany head, string shareName)
        {
            return false;
        }

        /// <summary>
        /// Adds the list node company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="newListNodeCompanyShare">The new list node company share.</param>
        /// <returns></returns>
        public static ListNodeCompany AddListNodeCompany(ListNodeCompany head ,ListNodeCompany newListNodeCompanyShare )
        {
            if (head == null)
                head = newListNodeCompanyShare;
            else
            {
               newListNodeCompanyShare.next =  head.next;
                head = newListNodeCompanyShare;
            }
            return head;
        }


        /// <summary>
        /// Deletes the list node company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="listNodecompanyObject">The list nodecompany object.</param>
        public static void DeleteListNodeCompany(ListNodeCompany head , ListNodeCompany listNodecompanyObject)
        {
            ListNodeCompany temp = null;

            if (head == null)
                return;
            else if((head.data.symbol).Equals( listNodecompanyObject.data.symbol))
                head = head.next;
            else
            {
                temp = head;

                while(temp.next != null && !((temp.next.data.symbol).Equals(listNodecompanyObject.data.symbol)))
                    temp = temp.next;

                if(temp.next != null)
                    if((temp.next.data.symbol).Equals(listNodecompanyObject.data.symbol))
                        temp.next = temp.next.next;
                else
                    Console.WriteLine("listnodecompany node not found");
            }
        }
        ////readfile()
        ////deserializeObject()
        //// methods for linkedlist operation
        ////methods for operation for queue using linked list
        ////methods for operation for stack using linked list
    }
}
