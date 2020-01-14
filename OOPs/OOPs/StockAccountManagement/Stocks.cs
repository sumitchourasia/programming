using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace OOPs.StockAccountManagement
{
   public class Stocks
    {
        public void StocksMethod()
        {
            string memberStockPath = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\StockAccountManagement\MemberStockFile.json";
            string customerStockPath = @"C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\StockAccountManagement\CustomerStockFile.json";

            string memberberStockInString = Utility.ReadFile(memberStockPath);
            string customerStockInString = Utility.ReadFile(customerStockPath);

            Console.WriteLine(memberberStockInString);
            Console.WriteLine(customerStockInString);

             StockPortfolio memberstockobject = Utility.DeserialiseTheObject(memberberStockInString);
             Utility.PrintStock(memberstockobject);
             Console.WriteLine("is empty");

        }

    }
}
