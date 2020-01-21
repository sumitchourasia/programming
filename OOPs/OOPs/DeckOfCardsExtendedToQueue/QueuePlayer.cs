using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    /// <summary>
    /// Queue to maintain all the player
    /// </summary>
    public class QueuePlayer
    {
       private ListNodePlayer front = null;
       private ListNodePlayer rear = null;

        /// <summary>
        /// Gets or sets the front.
        /// </summary>
        /// <value>
        /// The front.
        /// </value>
        public ListNodePlayer Front { get => this.front; set => this.front = value; }
        /// <summary>
        /// Gets or sets the rear.
        /// </summary>
        /// <value>
        /// The rear.
        /// </value>
        public ListNodePlayer Rear { get => this.rear; set => this.rear = value; }
    }
}
