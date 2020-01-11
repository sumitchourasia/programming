using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inventory_Details
{
    public class InventoryData
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKg;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name {
            set 
            {
                this.Name = value;
            }
            get
            {
                return this.Name;
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
        /// Gets or sets the priceperkg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            set
            {
                this.pricePerKg = value;
            }
            get
            {
                return this.pricePerKg;
            }
        }
    }
}
