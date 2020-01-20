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
        MemberStockPortfolio memberStockPortfolioObject = null;
        CustomerShare customerShareAccount = null;

        /// <summary>
        /// Creates new stockAccount.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public MemberStockPortfolio NewStockAccount(string filePath)
        {
            ////read the file using path
            string jsonString = Utility.ReadFile(filePath);
            Console.WriteLine(jsonString);
            ////deserialize the object
            memberStockPortfolioObject = Utility.Deserialize(jsonString);
            return memberStockPortfolioObject;
        }

        /// <summary>
        /// Creates new customershareaccount.
        /// </summary>
        /// <returns></returns>
        public CustomerShare NewCustomerShareAccount()
        {
            customerShareAccount = new CustomerShare();
            return customerShareAccount;
        }


        /// <summary>
        /// Values the of stock share
        /// </summary>
        /// <returns></returns>
        public double ValueOf()
        {
            double totalValue = 0.0;
            IList <MemberStockData> list = memberStockPortfolioObject.memberStockList;
            foreach(var share in list)
                totalValue =   share.NumberOfShare * share.SharePrice; 
            return totalValue;
        }

        /// <summary>
        /// Buys the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void Buy( MemberStockPortfolio memberStockPortfolioObject ,StackUsingLL stack , QueueLL queueLL )
        {
            CompanyShare companyShareObject = null;
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
            companyShareObject  = Utility.CheckShareNameIsInLinkedListCompany(customerShareAccount.Head, shareName);

                ////create new companyobject wrap it in listnodecompany node and add to linked list
                if (companyShareObject == null)
                {
                companyShareObject = new CompanyShare();
                companyShareObject.Symbol = shareName;
                newListNodeCompanyShare = Utility.CreateListNodeCompany();
                //// update date time here
                newListNodeCompanyShare.Data = companyShareObject;
                //// add the newCompanyShare into linkedlist
                customerShareAccount.Head = Utility.AddListNodeCompany(customerShareAccount.Head, newListNodeCompanyShare);
                }

            //// decrease the numberoofshare from member stock object and add the number of share to CompanyObject of LinkedList
            Utility.MakePurchase(memberStockPortfolioObject, companyShareObject, numberOfShare);

            string item = " purchase \t" + companyShareObject.Symbol + "\t " + companyShareObject.NumberOfShare + "\t " + companyShareObject.DateTime;
            stack.push(item);
            queueLL.Enque(item);
            //// for every Buy operation put the companyshareobject to the QueueCompanyTransaction
            ////add the companyshareObject to the stack.

        }

        /// <summary>
        /// Sells the specified amount.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="symbol">The symbol.</param>
        public void Sell( MemberStockPortfolio memberStockPortfolioObject , StackUsingLL stack , QueueLL queueLL)
        {
            Console.WriteLine("enter the shareName to sell ");
            string shareName = Utility.ReadString();
            Console.WriteLine("enter the NumberOfShare to sell");
            int numberOfShare = Utility.ReadInt();

            ////check for available stock in companyshareobject inside Companylinkedlist and return companyshareobject
            CompanyShare companyShareObject = Utility.CheckShareAvailableInLinkedListCompany(customerShareAccount.Head, shareName, numberOfShare);
            if(companyShareObject == null )
            {
                Console.WriteLine("company share not available");
                return;
            }
            ////subtract share of stock from that companyshareobject that is inside companylinkedlist
            //// update into Memberstockobject
            Utility.MakeSell(numberOfShare, companyShareObject,memberStockPortfolioObject);
            string item = " sold \t" + companyShareObject.Symbol + "\t " + companyShareObject.NumberOfShare + "\t " + companyShareObject.DateTime;

            ////for every sell transaction , add the status to the queueCompanytransaction
            stack.push(item);
            
            ////for every sell transaction add the status to the queueCompanytransaction
            queueLL.Enque(item);

            ////check if number of shares are equal then delete the node(companyShareObject).
            if (companyShareObject.NumberOfShare == 0)
            customerShareAccount.Head  = Utility.DeleteListNodeCompany(customerShareAccount.Head, companyShareObject);
        }

        /// <summary>
        /// serialize the object to json file
        /// </summary>
        /// <param name="file">The file.</param>
        public void Save(string fileName)
        {
           string jsonResultString = JsonConvert.SerializeObject(memberStockPortfolioObject);
           File.WriteAllText(fileName,jsonResultString);
        }

        /// <summary>
        /// Saves the customer share to a file (serialize)
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void SaveCustomerShare(string fileName)
        {
            string jsonResultString = JsonConvert.SerializeObject(customerShareAccount);
            File.WriteAllText(fileName,jsonResultString);
        }

        /// <summary>
        /// Prints the report of all the shares in linked list
        /// </summary>
        public void PrintReport(MemberStockPortfolio memberStockPortfolioObject)
        {
            IList<MemberStockData> list = memberStockPortfolioObject.memberStockList;
            Console.WriteLine("ShareName \t  NumberOfShare \t SharePrice");
            foreach(var share in list)
                Console.WriteLine(share.ShareName + "\t" + share.NumberOfShare + " \t"+share.SharePrice);
            PrintCustomerShareReport(customerShareAccount);
            Console.WriteLine("Remaining Deposit is : "+DataProcessing.deposit);
        }

        /// <summary>
        /// Prints the list.
        /// </summary>
        /// <param name="head">The head.</param>
        public void PrintCustomerShareReport(CustomerShare customerShareObject)
        {
            if (customerShareObject.Head == null)
                return;
            else
            {
                ListNodeCompany temp = customerShareObject.Head;
                Console.WriteLine("shareName \t\t numberofshare");
                while(temp != null)
                {
                    Console.WriteLine(temp.Data.Symbol + "\t\t" + temp.Data.NumberOfShare + "\t");
                    temp = temp.Next;
                }
            }
        }
    }
}
