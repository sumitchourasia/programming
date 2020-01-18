using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class for Commercial Data processing
    /// </summary>
    public class DataProcessing
    {
        /// <summary>
        /// method to execute the CommercialDataProcessing program
        /// </summary>
        public void DataProcessingMethod()
        {
            string memberStockFilePath = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\CommercialDataProcessing\MemberStock.json";
            ////  string customerStockFilePath = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\CommercialDataProcessing\CustomerStockFile.json";

            ////read the file using path
            string memberstockjsonstring = Utility.ReadFile(memberStockFilePath);

            Console.WriteLine(memberstockjsonstring);

            ////deserialize the object
            MemberStockPortfolio memberStockPortfolioObject = Utility.Deserialize(memberstockjsonstring);

            //// print the memberstockdetails
            Utility.PrintMemberStock(memberStockPortfolioObject);

            ////create StockAccountobject  
            StockAccount stockAccountObject = new StockAccount();
            string decision = string.Empty;

            do
            {
                Console.WriteLine("enter your choice : ");
                Console.WriteLine(" 1 -> Buy share ");
                Console.WriteLine(" 2 -> Sell Share");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        stockAccountObject.Buy(memberStockPortfolioObject );
                        stockAccountObject.PrintReport(memberStockPortfolioObject);
                        break;

                    case 2:
                        stockAccountObject.Sell(memberStockPortfolioObject);
                        stockAccountObject.PrintReport(memberStockPortfolioObject);
                        break;

                    default:
                        return;
                }
                Console.WriteLine("do you wish to contine :  (yes / no)");
                decision = Console.ReadLine();
            } while (decision != "no");
        }
    }
}
