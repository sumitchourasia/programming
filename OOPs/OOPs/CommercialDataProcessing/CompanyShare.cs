using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class companyShare object used to insert into the linkedList upon any transaction
    /// </summary>
    public class CompanyShare
    {
        private string symbol;
        private int numberOfShare;
        private DateTime dateTime;

        /// <summary>
        /// Gets or sets the symbol.
        /// </summary>
        /// <value>
        /// The symbol.
        /// </value>
        public string Symbol { get => this.symbol; set => this.symbol = value;}

        /// <summary>
        /// Gets or sets the number of share.
        /// </summary>
        /// <value>
        /// The number of share.
        /// </value>
        public int NumberOfShare { get => this.numberOfShare ; set => this.numberOfShare = value ; }

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public DateTime DateTime { get => this.dateTime ; set => this.dateTime = value ; }
    }
}
