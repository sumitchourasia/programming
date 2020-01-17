using System;

namespace OOPs.CommercialDataProcessing
{
    public class StockAccount : IStockAccount
    {

        ListNodeCompany Head = Utility.CreateLinkedList();


        public void NewStockAccount(string fileName)
        {
            
        }

        public double ValueOf()
        {

            return 0.0;
        }

        public void Buy(int amount, string symbol)
        {
            Console.WriteLine("which share you want to buy : ");
            string shareName = Console.ReadLine();
            Console.WriteLine("how much number of share you want to buy : ");
            int numberOfShare =Convert.ToInt32(Console.ReadLine());

            bool shareAvailable = Utility.CheckShareAvailable(this.Head, shareName , numberOfShare);

            if(shareAvailable == false)
            {
                Console.WriteLine("share not available");
                return;
            }


            

            ////check for availbale stock in memberStockObject
            ////check for companyshareobject in the Companylinkedlist
            ////create companyshare object using NewStockAccount()
            ////add share of stock to companyShareObject.numberOfShare
            ////remove share of stock from the original place i.e MemberStockObject
            ////wrap company share object arount a listnodecompany
            ////add companyshareobject to Companylinkedlist

            //// for every Buy operation put the companyshareobject to the QueueCompanyTransaction
        }

        public void Sell(int amount, string symbol)
        {
            ////check for available stock in companyshareobject inside Companylinkedlist
            ////subtract share of stock from that companyshareobject that is inside companylinkedlist 
            //// update into Memberstockobject

            ////for every sell transaction add the companyshareobject to the queueCompanytransaction
        }
        public void Save(string file)
        {

        }
        public void PrintReport()
        {

        }

    }
}
