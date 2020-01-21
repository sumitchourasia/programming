using System;
using System.Collections.Generic;


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
        public List<InventoryItemData> Rice { get; set; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public List<InventoryItemData> Wheat { get; set; }

        /// <summary>
        /// Gets or sets the pulses.
        /// </summary>
        /// <value>
        /// The pulses.
        /// </value>
        public List<InventoryItemData> Pulses { get; set; }
    }
}
