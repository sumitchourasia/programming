using System;

namespace OOPs.CommercialDataProcessing
{
    /// <summary>
    /// create a Queue Class using Linked list
    /// </summary>
    public class QueueLL
    {
        private ListNodeStatus front;
        private ListNodeStatus rear;

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public ListNodeStatus Front { get => this.front ; set => this.front = value; }

        /// <summary>
        /// Gets or sets the rear.
        /// </summary>
        /// <value>
        /// The rear.
        /// </value>
        public ListNodeStatus Rear { get => this.rear; set => this.rear = value; }

        /// <summary>
        /// Determines whether [is empty queue].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is empty queue]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEmptyQueue()
        {
            return Front == Rear;
        }

        /// <summary>
        /// Enques the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void Enque(string item)
        {
            ListNodeStatus newnode = new ListNodeStatus();
            newnode.Status = item;

            if(Rear == null)
                Rear = newnode;
            else
            {
                Rear.Next = newnode;
                Rear = newnode;
            }

            if (Front == null)
                Front = Rear;
        }

        /// <summary>
        /// Deques this instance.
        /// </summary>
        /// <returns></returns>
        public string Deque()
        {
            ListNodeStatus temp = null;
            if (front == null)
                return null;
            else
            {
                temp = front;
                front = front.Next;
            }
            return temp.Status;
        }


    }
}
