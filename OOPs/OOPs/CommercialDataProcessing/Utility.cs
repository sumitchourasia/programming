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
                if ((share.ShareName).Equals(shareName))
                    if (share.NumberOfShare >= numberOfShare && DataProcessing.deposit>=(share.NumberOfShare*share.SharePrice))
                        return share;
                    else
                        Console.WriteLine("number of share is only : {0} ", share.NumberOfShare);
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
            if (head == null)
                return null;
            else if ((head.Data.Symbol).Equals(shareName) && (head.Data.NumberOfShare >= numberOfShare))
                return head.Data;
            else
            {
                temp = head;
                while (temp != null)
                {
                    if ((temp.Data.Symbol).Equals(shareName) && temp.Data.NumberOfShare >= numberOfShare)
                        return temp.Data;
                    temp = temp.Next;
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
                return null;
            else if ((head.Data.Symbol).Equals(shareName))
                return head.Data;
            else
            {
                temp = head;
                while (temp != null)
                {
                    if ((temp.Data.Symbol).Equals(shareName))
                        return temp.Data;
                    temp = temp.Next;
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
                if (share.ShareName.Equals(companyShareObject.Symbol))
                {
                    share.NumberOfShare = share.NumberOfShare - numberOfShare;
                    companyShareObject.NumberOfShare = companyShareObject.NumberOfShare + numberOfShare;
                    DataProcessing.deposit -= (share.NumberOfShare * share.SharePrice); 
                    companyShareObject.DateTime = DateTime.Now;
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
            foreach(var share in list)
                if(share.ShareName .Equals(companyShareObject.Symbol))
                {
                    share.NumberOfShare += numberOfShare;
                    companyShareObject.NumberOfShare -= numberOfShare;
                    DataProcessing.deposit += share.NumberOfShare * share.SharePrice ;
                    companyShareObject.DateTime = DateTime.Now;
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
                while (temp.Next != null)
                       temp = temp.Next;
                temp.Next = newListNodeCompanyShare;
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
            else if((head.Data.Symbol).Equals(companyShareObject.Symbol))
                head = head.Next;
            else
            {
                temp = head;
                while(temp.Next != null && !((temp.Next.Data.Symbol).Equals(companyShareObject.Symbol)))
                    temp = temp.Next;
                if(temp.Next != null)
                     if((temp.Next.Data.Symbol).Equals(companyShareObject.Symbol))
                        temp.Next = temp.Next.Next;
                else
                    Console.WriteLine("listnodecompany node not found");
            }
            return head;
        }

        /// <summary>
        /// Prints the transaction.
        /// </summary>
        /// <param name="stack">The stack.</param>
        public static void PrintTransaction( StackUsingLL stack )
        {
            ListNodeStatus temp;
            if (stack == null || stack.head == null)
                return;
            else
            {
                temp = stack.head;
                while(temp != null)
                {
                    Console.WriteLine(temp.Status);
                    temp = temp.Next;
                }

            }
        }

        /// <summary>
        /// Prints the date time.
        /// </summary>
        /// <param name="queueLL">The queue ll.</param>
        public static void PrintDateTime(QueueLL queueLL)
        {
            ListNodeStatus temp = null;
            if (queueLL == null)
                return;
            else
            {
                temp = queueLL.Front;
                while(temp != null)
                {
                    Console.WriteLine(temp.Status);
                    temp = temp.Next;
                }
            }
        }
    }
}