using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    /// <summary>
    /// player class
    /// </summary>
    public class Player
    {
        /// <summary>
        /// The card queue for each player
        /// </summary>
        public QueueCard queueCard = Utility.CreateQueueCard();
    }
}
