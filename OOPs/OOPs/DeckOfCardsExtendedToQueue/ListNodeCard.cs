using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    /// <summary>
    /// List node to store card.
    /// </summary>
   public class ListNodeCard
    {
        private string suit;
        private int rank;
        private ListNodeCard next;

        /// <summary>
        /// Gets or sets the suit.
        /// </summary>
        /// <value>
        /// The suit.
        /// </value>
        public string Suit { get => this.suit; set => this.suit = value ; }

        /// <summary>
        /// Gets or sets the rank.
        /// </summary>
        /// <value>
        /// The rank.
        /// </value>
        public int Rank { get => this.rank; set => this.rank = value; }
        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        /// <value>
        /// The next.
        /// </value>
        public ListNodeCard Next { get => this.next; set => this.next = value; }
    }
}
