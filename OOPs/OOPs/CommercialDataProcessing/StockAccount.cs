using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// stockAccount class implements the interface IstockAccount
    /// </summary>
    /// <seealso cref="OOPs.CommercialDataProcessing.IStockAccount" />
    public class StockAccount : IStockAccount
    {
        /// <summary>
        /// create the new linked List
        /// </summary>
        ListNodeCompany Head = Utility.CreateLinkedList();

        /// <summary>
        /// Creates new stockAccount.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void NewStockAccount(string fileName)
        {
            
        }

        /// <summary>
        /// Values the of stock share
        /// </summary>
        /// <returns></returns>
        public double ValueOf()
        {

            return 0.0;
        }

        /// <summary>
        /// Buys the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void Buy( MemberStockPortfolio memberStockPortfolioObject )
        {
            CompanyShare companyObject = null;
            ListNodeCompany newListNodeCompanyShare = null;
            Console.WriteLine("which share you want to buy : ");
            string shareName = Console.ReadLine();
            Console.WriteLine("how much number of share you want to buy : ");
            int numberOfShare = Convert.ToInt32(Console.ReadLine());

            ////check for availbale stock in memberStockObject
            ////look into the member stock object
            MemberStockData memberStockShareAvailable = Utility.CheckShareAvailableInMemberStockObject(memberStockPortfolioObject, shareName, numberOfShare);
            if (memberStockShareAvailable == null)
            {
                Console.WriteLine("share not available");
                return;
            }
            ////check if deposit >= totalPrice of share. (numberOfshare * memberstockobjectlist.sharePrice)
            ////if false then return.

            ////fetch the CompanyObject reference from the linked list
            companyObject  = Utility.CheckShareNameIsInLinkedListCompany(Head, shareName);
            if(companyObject == null)
            {
                Console.Write("companyObject is null");
            }
            if (Head != null)
                Console.WriteLine("head is not null");
            else
            {
                Console.WriteLine("head is null");
            }
           
            ////create new companyobject wrap it in listnodecompany node and add to linked list
            if (companyObject == null)
            {
                if(companyObject == null)
                Console.WriteLine("creating new CompanyShareObjec");
                companyObject = new CompanyShare();
                companyObject.symbol = shareName;
                newListNodeCompanyShare = Utility.CreateListNodeCompany();
                //// update date time here
                newListNodeCompanyShare.data = companyObject;
                //// add the newCompanyShare into linkedlist
                this.Head = Utility.AddListNodeCompany(Head, newListNodeCompanyShare);
               
            }

            //// decrease the numberoofshare from member stock object and add the number of share to CompanyObject of LinkedList
            Utility.MakePurchase(memberStockPortfolioObject, companyObject , numberOfShare);

            //// for every Buy operation put the companyshareobject to the QueueCompanyTransaction
            ////add the companyshareObject to the stack.

        }

        /// <summary>
        /// Sells the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void Sell( MemberStockPortfolio memberStockPortfolioObject)
        {
            Console.WriteLine("enter the shareName to sell ");
            string shareName = Utility.ReadString();
            Console.WriteLine("enter the NumberOfShare to sell");
            int numberOfShare = Utility.ReadInt();

            ////check for available stock in companyshareobject inside Companylinkedlist and return companyshareobject
            ////internally check if number of shares are equal then delete the node(companyShareObject).
            CompanyShare companyShareObject = Utility.CheckShareAvailableInLinkedListCompany(Head, shareName, numberOfShare);
           
            if(companyShareObject == null )
            {
                Console.WriteLine("company share not available");
                return;
            }

            ////subtract share of stock from that companyshareobject that is inside companylinkedlist
            //// update into Memberstockobject
            Utility.MakeSell(numberOfShare, companyShareObject,memberStockPortfolioObject);
            if (companyShareObject.numberOfShare == 0)
              this.Head  = Utility.DeleteListNodeCompany(Head, companyShareObject);

            ////for every sell transaction add the companyshareobject to the queueCompanytransaction
            //// add to stack
        }

        /// <summary>
        /// serialize the object to json file
        /// </summary>
        /// <param name="file">The file.</param>
        public void Save(string file)
        {
           
        }

        /// <summary>
        /// Prints the report of all the shares in linked list
        /// </summary>
        public void PrintReport(MemberStockPortfolio memberStockPortfolioObject)
        {
            IList<MemberStockData> list = memberStockPortfolioObject.memberStockList;
            Console.WriteLine("ShareName \t  NumberOfShare \t SharePrice");
            foreach(var share in list)
            {
                Console.WriteLine(share.shareName + "\t" + share.numberOfShare + " \t"+share.sharePrice);
            }

            PrintList(Head);
        }

        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="head">The head.</param>
        public static void PrintList(ListNodeCompany head)
        {
            if (head == null)
                return;
            else
            {
                ListNodeCompany temp = head;
                Console.WriteLine("shareName \t\t numberofshare");
                while(temp != null)
                {
                    Console.WriteLine(temp.data.symbol + "\t\t" + temp.data.numberOfShare + "\t");
                    temp = temp.next;
                }
            }
        }
    }
}
