using System;
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
        public void Buy(int amount, string symbol)
        {
            ListNodeCompany newListNodeCompanyShare = null;
            Console.WriteLine("which share you want to buy : ");
            string shareName = Console.ReadLine();
            Console.WriteLine("how much number of share you want to buy : ");
            int numberOfShare = Convert.ToInt32(Console.ReadLine());

            ////check for availbale stock in memberStockObject
            ////look into the member stock object
            bool shareAvailable = Utility.CheckShareAvailableInMemberStockObject(Head, shareName, numberOfShare);

            if (shareAvailable == false)
            {
                Console.WriteLine("share not available");
                return;
            }

            ////check if deposit >= totalPrice of share. (numberOfshare * memberstockobjectlist.sharePrice)
            ////if false then return.

            bool CompanyObjectPresent = Utility.CheckShareNameIsInLinkedListCompany(Head, shareName);

            if (CompanyObjectPresent == false)
            {
                CompanyShare newCompanyShare = new CompanyShare();
                newCompanyShare.symbol = shareName;
                newListNodeCompanyShare = Utility.CreateListNodeCompany();

                //// decrease the numberoofshare from member stock object. 

                newCompanyShare.numberOfShare = numberOfShare;

                //// update date time here

                newListNodeCompanyShare.data = newCompanyShare;

                //// add the newCompanyShare into linkedlist
                this.Head = Utility.AddListNodeCompany(Head, newListNodeCompanyShare);
            }

            ////check for companyshareobject in the Companylinkedlist
            ///
            //// fetch the CompanyObject reference from the linked list
            ///
            //// decrease the numbnerOfShare from the member stock.
            ///
            //// add the numberOfShare to the previous numberofshare field.

            //// for every Buy operation put the companyshareobject to the QueueCompanyTransaction
            ////add the companyshareObject to the stack.

        }

        /// <summary>
        /// Sells the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void Sell(int amount, string symbol)
        {
            Console.WriteLine("enter the shareName to sell ");
            string shareName = Utility.ReadString();
            Console.WriteLine("enter the NumberOfShare to sell");
            int numberOfShare = Utility.ReadInt();

            ////check for available stock in companyshareobject inside Companylinkedlist and return companyshareobject
            ////internally check if number of shares are equal then delete the node(companyShareObject).
            ListNodeCompany listNodecompany = Utility.CheckShareAvailableInLinkedListCompany(Head, shareName, numberOfShare);
           
            if(listNodecompany == null )
            {
                Console.WriteLine("company share not available");
                return;
            }

            ////subtract share of stock from that companyshareobject that is inside companylinkedlist
            listNodecompany.data.numberOfShare -= numberOfShare;

            //// update into Memberstockobject

            ////for every sell transaction add the companyshareobject to the queueCompanytransaction
            //// add to stack

            if (listNodecompany.data.numberOfShare == numberOfShare)
                Utility.DeleteListNodeCompany(Head,listNodecompany);

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
        public void PrintReport()
        {
            
        }

    }
}
