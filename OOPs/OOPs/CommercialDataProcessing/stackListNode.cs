using System;

namespace OOPs
{
    /// <summary>
    /// class for ListNode
    /// </summary>C:\Users\Bridgelabz\Documents\GitHub\programming\OOP's\OOPs\OOPs\stackListNode.cs
    public class ListNodeStatus
    {
       private string status;
       private ListNodeStatus next;

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status
        {
            get
            {
                return this.status;
            }
            set
            {
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public ListNodeStatus Next
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
