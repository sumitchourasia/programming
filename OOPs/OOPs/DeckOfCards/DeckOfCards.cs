using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs.DeckOfCards
{
    public class DeckOfCards
    {
        public void DeckOfCardsMethods()
        {
            string[] Suits = { "Club", "Diamond", "Heart", "Spade" };
            string[] Ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            string[,] CardArray = new string[4, 13];
            string[,] PlayerArray = new string[4, 13];

            ////Initialize card array
            Utility.InitializeCardArray(CardArray, Suits, Ranks);

            ////Shuffle the cards
            Utility.ShuffleCards(CardArray);

            ////Distributes 9 - 9 cards to each of 4 player
            Utility.DistributeCards(CardArray,PlayerArray);

            //// prints the cards with each players
            Utility.PrintString2DArray(PlayerArray);
        }
    }
}
