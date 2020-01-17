using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    /// <summary>
    /// program implementation of Deck of card using Queue datastructure implemented using linked list
    /// </summary>
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
            
            ////initialise the array to store all the cards 
            Utility.InitializeArray(DeckOfCards, Suits, Ranks);
            
            ////shuffle the deck of cardd
            Utility.Shuffle(DeckOfCards);

            ////create the Queue to hold all the players
            QueuePlayer queuePlayer = Utility.CreateQueuePlayer();

            ////add four player into the queue
            Utility.AddPlayersInQueue(queuePlayer);

            ////ditribute the cards in the DecksOfCard array to all the players in the queue.
            Utility.DistributeCards(queuePlayer,DeckOfCards);

            ////sort the cards of each off the player in the queue
            Utility.Sort(queuePlayer);

            Console.WriteLine("after sorting : ");

            ////print the entire queue.
            Utility.PrintQueuePlayer(queuePlayer);
        }
    }
}
