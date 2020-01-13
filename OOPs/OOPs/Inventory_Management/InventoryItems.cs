using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inventory_Management
{
    public class InventoryItems
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<ItemsData> Rice { get; set; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public List<ItemsData> Wheat { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<ItemsData> Pulses { get; set; }
    }
}
