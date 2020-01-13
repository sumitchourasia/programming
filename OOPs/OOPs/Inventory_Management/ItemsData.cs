using System;

namespace OOPs.Inventory_Management
{
    /// <summary>
    /// class for itmes data
    /// </summary>
    public class ItemsData
    {
        public string name;
        public double weight;
        public double price;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight
        {
            set
            {
                this.weight = value;
            }
            get
            {
                return this.weight;
            }
        }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public double Price
        {
            set
            {
                this.price = value;
            }
            get
            {
                return this.price;
            }
        }
    }
}
