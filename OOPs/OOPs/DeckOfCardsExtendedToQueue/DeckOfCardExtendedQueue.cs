using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    public class DeckOfCardExtendedQueue
    {
        /// <summary>
        /// Deck Of Card extended using queue method.
        /// </summary>
        public void DeckOfCardExtendedQueueMethod()
        {
            string[] Suits = new string[] { "Club", "Diamond", "Spade", "Heart" };

            int[] Ranks = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

            string[,] DeckOfCards = new string[4, 13];

            Utility.InitializeArray(DeckOfCards, Suits, Ranks);
            Utility.Shuffle(DeckOfCards);

            QueuePlayer queuePlayer = Utility.CreateQueuePlayer();

            Utility.AddPlayersInQueue(queuePlayer);

            Utility.DistributeCards(queuePlayer,DeckOfCards);

            Utility.PrintQueuePlayer(queuePlayer);

        }
    }
}
