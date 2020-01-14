using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.StockAccountManagement
{
   public class StockData
    {
        /// <summary>
        /// The name
        /// </summary>
        public string sharename;
        /// <summary>
        /// The number of shares
        /// </summary>
        public double numberofshare;
        /// <summary>
        /// The share price
        /// </summary>
        public double shareprice;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string ShareName
        {
            get
            {
                return this.sharename;
            }
            set
            {
                this.sharename = value;
            }
        }

        /// <summary>
        /// Gets or sets the number of shares.
        /// </summary>
        /// <value>
        /// The number of shares.
        /// </value>
        public double NumberOfShares
        {
            set
            {
                this.numberofshare = value;
            }
            get
            {
                return this.numberofshare;
            }
        }

        /// <summary>
        /// Gets or sets the share price.
        /// </summary>
        /// <value>
        /// The share price.
        /// </value>
        public double SharePrice
        {
            set
            {
                this.shareprice = value;
            }
            get
            {
                return this.shareprice;
            }
        }

    }
}
