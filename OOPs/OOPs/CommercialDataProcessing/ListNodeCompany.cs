using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// class for Linked list node of type CompanyShare
    /// </summary>
    public class ListNodeCompany
    {
        private CompanyShare data;
        private ListNodeCompany next;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public CompanyShare Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public ListNodeCompany Next
        {
            get
            {
                return this.next;
            }
            set
            {
                this.next = value;
            }
        }
    }
}
