using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class to declare the memberstockdata
    /// </summary>
    public class MemberStockData
    {
        private string shareName;
        private int numberOfShare;
        private double sharePrice;

        /// <summary>
        /// Gets or sets the name of the share.
        /// </summary>
        /// <value>
        /// The name of the share.
        /// </value>
        public string ShareName { get => this.shareName; set => this.shareName = value; }

        /// <summary>
        /// Gets or sets the number of share.
        /// </summary>
        /// <value>
        /// The number of share.
        /// </value>
        public int NumberOfShare { get => this.numberOfShare; set => this.numberOfShare = value;}

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public double SharePrice { get => this.sharePrice ; set => this.sharePrice = value;}
    }
}
