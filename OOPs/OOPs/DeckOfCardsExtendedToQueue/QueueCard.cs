using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    /// <summary>
    /// Queue to maintain all the cards for each player
    /// </summary>
    public class QueueCard
    {
       private ListNodeCard front;
       private ListNodeCard rear;

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public ListNodeCard Front { get => this.front; set => this.front = value; }

        /// <summary>
        /// Gets or sets the rear.
        /// </summary>
        /// <value>
        /// The rear.
        /// </value>
        public ListNodeCard Rear { get => this.rear; set => this.rear = value; }
    }
}
