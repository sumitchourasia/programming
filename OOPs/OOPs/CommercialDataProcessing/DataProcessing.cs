using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class for Commercial Data processing
    /// </summary>
    public class DataProcessing
    {
        public static double deposit = 50000000;
        /// <summary>
        /// The member stock portfolio object
        /// </summary>
        MemberStockPortfolio memberStockPortfolioObject = null;

        /// <summary>
        /// The customer share account
        /// </summary>
        CustomerShare customerShareAccount = null;

        /// <summary>
        /// The stack linked list
        /// </summary>
        StackUsingLL stackLL = new StackUsingLL();
        
        /// <summary>
        /// The queue Using linked list
        /// </summary>
        QueueLL queueLL = new QueueLL();

        /// <summary>
        /// The static stock account object 
        /// </summary>
        public static StockAccount stockAccountObject = null;

        /// <summary>
        /// method to execute the CommercialDataProcessing program
        /// </summary>
        public void DataProcessingMethod()
        {
            /// string variable that has File Path
            string memberStockFilePath = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\CommercialDataProcessing\MemberStock.json";
            /// string variable that has File Path
            string customerStockFilePath = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\CommercialDataProcessing\CustomerStockFile.json";

            ///new StockAccount object instantiation.
            stockAccountObject = new StockAccount(); 

            int choice = 0;
            string decision = string.Empty;
            do
            {
                Console.WriteLine("enter your choice : ");
                Console.WriteLine(" 1 -> Create New StockAccount and CustomerShareAccount");
                Console.WriteLine(" 2 -> Total Value of stockAccount");
                Console.WriteLine(" 3 -> Buy share ");
                Console.WriteLine(" 4 -> Sell Share");
                Console.WriteLine(" 5 -> save stock data back to file");
                Console.WriteLine(" 6 -> save customer share to file");
                Console.WriteLine(" 7 -> PrintReport of stock");
                Console.WriteLine(" 8 -> printReport of customer stock");
                Console.WriteLine(" 9 -> print transaction done (stack)");
                Console.WriteLine("10 -> print Date time of transaction (Queue)");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        memberStockPortfolioObject = stockAccountObject.NewStockAccount(memberStockFilePath);
                        customerShareAccount = stockAccountObject.NewCustomerShareAccount();
                        break;

                    case 2:
                       Console.WriteLine("total value of all the stock shares are : {0}", stockAccountObject.ValueOf());
                        break;

                    case 3:
                        stockAccountObject.Buy(memberStockPortfolioObject ,stackLL,queueLL);
                        stockAccountObject.PrintReport(memberStockPortfolioObject);
                        break;

                    case 4:
                        stockAccountObject.Sell(memberStockPortfolioObject , stackLL ,queueLL);
                        stockAccountObject.PrintReport(memberStockPortfolioObject);
                        break;

                    case 5:
                        stockAccountObject.Save(memberStockFilePath);
                        break;

                    case 6:
                        stockAccountObject.SaveCustomerShare(customerStockFilePath);
                        break;

                    case 7:
                        stockAccountObject.PrintReport(memberStockPortfolioObject);
                        break;

                    case 8:
                        stockAccountObject.PrintCustomerShareReport(customerShareAccount);
                        break;

                    case 9:
                        Utility.PrintTransaction(stackLL);
                        break;

                    case 10:
                        Utility.PrintDateTime(queueLL);
                        break;

                    default:
                        return;
                }
            } while (choice < 11);
        }
    }
}
