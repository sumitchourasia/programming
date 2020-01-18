using System;

namespace OOPs.CommercialDataProcessing
{
    interface IStockAccount
    {
        void NewStockAccount(string fileName);
        double ValueOf();
        void Buy( MemberStockPortfolio memberStockPortfolioObject);
        void Sell( MemberStockPortfolio memberStockPortfolioObject);
        void Save(string file);
        void PrintReport(MemberStockPortfolio memberStockPortfolioObject);
    }
}
