using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.CommercialDataProcessing
{
    interface IStockAccount
    {
        void NewStockAccount(string fileName);
        double ValueOf();
        void Buy(int amount, string symbol);
        void Sell(int amount, string symbol);
        void Save(string file);
        void PrintReport();
    }
}
