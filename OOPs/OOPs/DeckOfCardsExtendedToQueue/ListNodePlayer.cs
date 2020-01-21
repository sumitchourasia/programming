using System;


namespace OOPs.DeckOfCardsExtendedToQueue
{
    /// <summary>
    /// List Node to store player.
    /// </summary>
    public class ListNodePlayer
    {
        private Player data;
        private ListNodePlayer next;

        public Player Data { get => this.data; set => this.data = value; }

        public ListNodePlayer Next { get => this.next; set => this.next = value; }
    }
}
