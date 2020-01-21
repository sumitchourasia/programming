using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// stack using linked list class
    /// </summary>
    public class StackUsingLL
    {
        /// <summary>
        /// The head
        /// </summary>
        public ListNodeStatus head;

        /// <summary>
        /// Determines whether [is empty stack].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is empty stack]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmptyStack()
        {
            return head == null;
        }

        /// <summary>
        /// Pushes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void push(string item)
        {
            ListNodeStatus newnode = new ListNodeStatus();
            newnode.Status = item;
            if (head == null)
                head = newnode;
            else
            {
                newnode.Next = head;
                head = newnode;
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public string pop()
        {
            ListNodeStatus temp = null;
            if (head == null)
                return null;
            else
            {
                temp = head;
                head = head.Next;
            }
            return temp.Status;
        }

        /// <summary>
        /// returns the toop element on the stack
        /// </summary>
        /// <returns></returns>
        public string Top()
        {
            if (head == null)
                return null;
            else
                return head.Status;
        }
    }
}
