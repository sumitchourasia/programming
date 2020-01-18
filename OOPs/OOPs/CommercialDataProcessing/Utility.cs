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
        public static MemberStockData CheckShareAvailableInMemberStockObject(MemberStockPortfolio memberStockPortfolioObject, string shareName , int numberOfShare)
        {
            IList<MemberStockData> list = memberStockPortfolioObject.memberStockList;
            foreach (var share in list)
                if ((share.shareName).Equals(shareName))
                    if (share.numberOfShare >= numberOfShare)
                        return share;
                    else
                        Console.WriteLine("number of share is only : {0} ",share.numberOfShare);

            return null;
        }

        /// <summary>
        /// Checks the share available in linked list company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <param name="numberOfShare">The number of share.</param>
        /// <returns></returns>
        public static CompanyShare CheckShareAvailableInLinkedListCompany(ListNodeCompany head ,string shareName , int numberOfShare )
        {
            ListNodeCompany temp = null;
            Console.WriteLine("inside checkshareavailableinlinkedlistcompany");
            if (head == null)
            {
                Console.WriteLine("head is null");
                return null;
            }
            else if ((head.data.symbol).Equals(shareName) && (head.data.numberOfShare >= numberOfShare))
            {
                Console.WriteLine("head data matched");
                return head.data;
            }
            else
            {
                temp = head;
                while (temp.next != null)
                {
                    if (temp.next.data.Equals(shareName) && temp.data.numberOfShare >= numberOfShare)
                    {
                        Console.WriteLine("temp data matched" + temp.data.symbol);
                        return temp.data;
                    }
                    temp = temp.next;
                }
            }

            return null;
        }

        /// <summary>
        /// Checks the share name is in linked list company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="shareName">Name of the share.</param>
        /// <returns></returns>
        public static CompanyShare CheckShareNameIsInLinkedListCompany(ListNodeCompany head, string shareName)
        {
            Console.WriteLine("inside CheckShareNameIsInLinkedListCompany");
            ListNodeCompany temp = null;
            if (head == null)
            {
                Console.WriteLine("head is null");
                return null;
            }
            else if ((head.data).Equals(shareName))
            {
                Console.WriteLine("head data matched");
                return head.data;
            }
            else
            {
                temp = head;
                while (temp.next != null)
                {
                    if ((temp.data.symbol).Equals(shareName))
                        return temp.data;
                    temp = temp.next;
                }
            }
            return null;
        }

        /// <summary>
        /// check if deposit is enough for the specified purchase
        /// </summary>
        /// <param name="deposit">The deposit.</param>
        /// <param name="numberOfShareToBuy">The number of share to buy.</param>
        /// <param name="sharePrice">The share price.</param>
        /// <returns></returns>
        public static bool DepositAvailable(int deposit , int numberOfShareToBuy, int sharePrice)
        {
            if (deposit >= (numberOfShareToBuy * sharePrice))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Makes the purchase.
        /// </summary>
        /// <param name="memberStockPortfolioObject">The member stock portfolio object.</param>
        /// <param name="companyShareObject">The company share object.</param>
        /// <param name="numberOfShare">The number of share.</param>
        public static void MakePurchase( MemberStockPortfolio memberStockPortfolioObject , CompanyShare companyShareObject , int numberOfShare )
        {
            IList<MemberStockData> list = memberStockPortfolioObject.memberStockList;
            foreach(var share in list)
            {
                if (share.ShareName.Equals(companyShareObject.symbol))
                {
                    share.numberOfShare = share.numberOfShare - numberOfShare;
                    companyShareObject.numberOfShare = companyShareObject.numberOfShare + numberOfShare;
                }
            }
        }

        /// <summary>
        /// Adds the share in company object.
        /// </summary>
        /// <param name="companyShareObject">The company share object.</param>
        /// <param name="numberOfShare">The number of share.</param>
        public static void MakeSell(int numberOfShare , CompanyShare companyShareObject , MemberStockPortfolio memberStockPortfolioObject )
        {
            IList<MemberStockData> list = memberStockPortfolioObject.memberStockList;
            Console.WriteLine("inside makesell");   
            foreach(var share in list)
            {
                Console.WriteLine("inside foreach loop : "+share.shareName);
                if(share.shareName .Equals(companyShareObject.symbol))
                {
                    share.numberOfShare += numberOfShare;
                    companyShareObject.numberOfShare -= numberOfShare;
                    Console.WriteLine(" share.numberOfShare = " + share.numberOfShare + " companyShareObject.numberOfShare " + companyShareObject.numberOfShare);
                }
            }
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
                ListNodeCompany temp = head;
                while (temp.next != null)
                       temp = temp.next;
                temp.next = newListNodeCompanyShare;
            }
            return head;
        }


        /// <summary>
        /// Deletes the list node company.
        /// </summary>
        /// <param name="head">The head.</param>
        /// <param name="listNodecompanyObject">The list nodecompany object.</param>
        public static ListNodeCompany DeleteListNodeCompany(ListNodeCompany head , CompanyShare companyShareObject)
        {
            ListNodeCompany temp = null;
            if (head == null)
                return null;
            else if((head.data.symbol).Equals(companyShareObject.symbol))
                head = head.next;
            else
            {
                temp = head;
                while(temp.next != null && !((temp.next.data.symbol).Equals(companyShareObject.symbol)))
                    temp = temp.next;

                if(temp.next != null)
                    if((temp.next.data.symbol).Equals(companyShareObject.symbol))
                        temp.next = temp.next.next;
                else
                    Console.WriteLine("listnodecompany node not found");
            }
            return head;
        }
    }
}