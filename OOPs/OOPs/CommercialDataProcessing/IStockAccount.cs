using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// interface to declare the following methods.
    /// </summary>
    interface IStockAccount
    {
        /// <summary>
        /// Creates new stockaccount.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        MemberStockPortfolio NewStockAccount(string fileName);

        /// <summary>
        /// prints the value of total stock price
        /// </summary>
        /// <returns></returns>
        double ValueOf();

        /// <summary>
        /// Buys the specified amount of share and updates the stack and queue 
        /// /// </summary>
        /// <param name="memberStockPortfolioObject">The member stock portfolio object.</param>
        /// <param name="stack">The stack.</param>
        /// <param name="queueLL">The queue ll.</param>
        void Buy( MemberStockPortfolio memberStockPortfolioObject,StackUsingLL stack ,QueueLL queueLL);

        /// <summary>
        /// Sells the specified amount and updates the stack and queue.
        /// </summary>
        /// <param name="memberStockPortfolioObject">The member stock portfolio object.</param>
        /// <param name="stack">The stack.</param>
        /// <param name="queueLL">The queue ll.</param>
        void Sell(MemberStockPortfolio memberStockPortfolioObject, StackUsingLL stack, QueueLL queueLL);

        /// <summary>
        /// Saves the specified filename (serialize)
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        void Save(string fileName);

        /// <summary>
        /// Prints the detailed stock report.
        /// </summary>
        /// <param name="memberStockPortfolioObject">The member stock portfolio object.</param>
        void PrintReport(MemberStockPortfolio memberStockPortfolioObject);
    }
}
