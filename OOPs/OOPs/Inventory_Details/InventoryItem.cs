using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.Inventory_Details
{
    public class InventoryItem
    {
        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<InventoryData> Rice { get; set; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public List<InventoryData> Wheat { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<InventoryData> Pulses { get; set; }
    }
}
