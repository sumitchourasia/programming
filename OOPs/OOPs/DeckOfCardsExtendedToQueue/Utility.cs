using System;

namespace OOPs.DeckOfCardsExtendedToQueue
{
    public static class Utility
    {
        /// <summary>
        /// Generates the random number 
        /// </summary>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static int GenerateRandom(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }
            
        /// <summary>
        /// Initializes the 2-D String array.
        /// </summary>
        /// <param name="CardArray">The card array.</param>
        /// <param name="Suits">The suits.</param>
        /// <param name="Ranks">The ranks.</param>
        public static void InitializeArray(string[,] CardArray , string[] Suits , int[] Ranks)
        {
            for(int i=0;i<CardArray.GetLength(0);i++)
            {
                for(int j=0;j<CardArray.GetLength(1);j++)
                {
                    if (j < 8)
                    {
                        CardArray[i, j] = Suits[i] + "-" + Ranks[j];
                    }
                    else if(j == 8)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "Jack";
                    }
                    else if (j == 9)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "Queen";
                    }
                    else if (j == 10)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "King";
                    }
                    else if (j == 11)
                    {
                        CardArray[i, j] = Suits[i] + "-" + "Ace";
                    }
                }
            }
        }

        /// <summary>
        /// Shuffles the specified array.
        /// </summary>
        /// <param name="Array">The array.</param>
        public static void Shuffle(string[,] Array)
        {
            int rowIndex1 = 0;
            int ColumnIndex1 = 0;
            int rowIndex2 = 0;
            int ColumnIndex2 = 0;

            for(int i=0;i<52;i++)
            {
                rowIndex1 = GenerateRandom(4);
                ColumnIndex1 = GenerateRandom(13);
                rowIndex2 = GenerateRandom(4);
                ColumnIndex2 = GenerateRandom(13);
                ////call the swap method to swap the elements of array
                Swap(Array,rowIndex1, ColumnIndex1, rowIndex2, ColumnIndex2);
            }
        }

        /// <summary>
        /// Swaps the specified elements of array.
        /// </summary>
        /// <param name="Array">The array.</param>
        /// <param name="rowIndex1">The row index1.</param>
        /// <param name="columnIndex1">The column index1.</param>
        /// <param name="rowIndex2">The row index2.</param>
        /// <param name="columnIndex2">The column index2.</param>
        public static void Swap(string[,] Array , int rowIndex1,int columnIndex1,int rowIndex2,int columnIndex2)
        {
            string temp = Array[rowIndex1,columnIndex1];
            Array[rowIndex1,columnIndex1] = Array[rowIndex2,columnIndex2];
            Array[rowIndex2, columnIndex2] = temp;
        }

        /// <summary>
        /// Print the 2-D string array.
        /// </summary>
        /// <param name="Array">The array.</param>
        public static void Print2DStringArray(string[,] Array)
        {
            for(int i=0;i<Array.GetLength(0);i++)
            {
                for(int j=0;j<Array.GetLength(1);j++)
                {
                    Console.Write(Array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Creates the queue for players.
        /// </summary>
        /// <returns></returns>
        public static QueuePlayer CreateQueuePlayer()
        {
            QueuePlayer queuePlayer = new QueuePlayer();
            queuePlayer.Front = null;
            queuePlayer.Rear = null;
            return queuePlayer;
        }

        /// <summary>
        /// Creates the Queue to store cards for players
        /// </summary>
        /// <returns></returns>
        public static QueueCard CreateQueueCard()
        {
            QueueCard queueCard = new QueueCard();
            queueCard.Front = null;
            queueCard.Rear = null;
            return queueCard;
        }

        /// <summary>
        /// Adds the players.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        public static void AddPlayersInQueue(QueuePlayer queuePlayer)
        {
            for (int i=0;i<4;i++)
            { 
                Player player = new Player();
                AddPlayers(queuePlayer,player);
            }
        }

        /// <summary>
        /// Adds the players in queue.
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        /// <param name="player">The player.</param>
        public static void AddPlayers(QueuePlayer queuePlayer, Player playerObj)
        {
            ListNodePlayer playerNode = new ListNodePlayer();
            playerNode.Data = playerObj;

            if (queuePlayer.Rear == null)
                queuePlayer.Rear = playerNode;
            else
            {
                queuePlayer.Rear.next = playerNode;
                queuePlayer.Rear = playerNode;
            }

            if (queuePlayer.Front == null)
                queuePlayer.Front = queuePlayer.Rear;
        }

        /// <summary>
        /// Distributes the cards to each player one by one
        /// </summary>
        /// <param name="queuePlayer">The queue player.</param>
        /// <param name="Array">The array.</param>
        public static void DistributeCards(QueuePlayer queuePlayer , string[,] Array)
        {
            ListNodePlayer tempPlayer = queuePlayer.Front;
            
            for(int i=0;i<13;i++)
            {
                ////select the player
                tempPlayer = queuePlayer.Front;
                for(int j=0;j<4;j++)
                {
                    ////create a new card to insert into the queue card of player
                    ListNodeCard card = new ListNodeCard();
                    ////assing the values (suit and rank) from array to card
                    card = InputCardData(card , Array[j,i]);
                    ////insert the card to the specified player's queue
                    if(card != null)
                        AddCardsToQueueCard(tempPlayer.Data.queueCard, card);
                   ////go to next player
                    tempPlayer = tempPlayer.next;
                }
            }
        }

        /// <summary>
        /// Inputs the card data.
        /// </summary>
        /// <param name="card">The card.</param>
        /// <param name="input">The input.</param>
        public static ListNodeCard InputCardData(ListNodeCard card , string input)
        {
            string[] splitArray = null;
            if (input != null)
                splitArray = input.Split("-");
            else
            {
               // Console.WriteLine("input is null");
                return null;
            }
           
            card.Suit = splitArray[0];
            int rank = 0;

            if (splitArray[1] == "Jack")
            {
                card.Rank = 11;
            }
            else if(splitArray[1] == "Queen")
            {
                card.Rank = 12;
            }
            else if (splitArray[1] == "King")
            {
                card.Rank = 13;
            }
            else if (splitArray[1] == "Ace")
            {
                card.Rank = 14;
            }
            else
            {
                rank = Convert.ToInt32(splitArray[1]);
                card.Rank = rank;
            }
            return card;
        }

        /// <summary>
        /// Adds the cards to players'queue
        /// </summary>
        /// <param name="queueCard">The queue card.</param>
        /// <param name="card">The card.</param>
        public static void AddCardsToQueueCard(QueueCard queueCard , ListNodeCard card)
        {
            ListNodeCard temp = null;
            if(queueCard.Rear == null)
            {
                queueCard.Rear = card;
            }
            else
            {
                temp = queueCard.Rear;
                temp.next = card;
                queueCard.Rear = card;
            }
            if(queueCard.Front == null)
            {
                queueCard.Front = queueCard.Rear;
            }
        }

        /// <summary>
        /// Prints the queue player.
        /// </summary>
        public static void PrintQueuePlayer(QueuePlayer queuePlayer)
        {
            int count = 0;
            ////Console.WriteLine("inside printQueuePlayer method");
            ListNodeCard tempPlayerCard = null;
            ListNodePlayer tempPlayer = queuePlayer.Front;
            while(tempPlayer != null)
            {
                Console.WriteLine("Player "+ ++count);
                tempPlayerCard = tempPlayer.Data.queueCard.Front;
                while(tempPlayerCard != null)
                {
                    if (tempPlayerCard.Rank > 10)
                    {
                        if(tempPlayerCard.Rank == 11)
                        {
                            Console.Write(tempPlayerCard.Suit +"-"+"Jack  ");
                        }
                        else if(tempPlayerCard.Rank == 12)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "Queen  ");
                        }
                        else if(tempPlayerCard.Rank == 13)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "King  ");
                        }
                        else if(tempPlayerCard.Rank == 14)
                        {
                            Console.Write(tempPlayerCard.Suit + "-" + "Ace  ");
                        }
                    }
                    else
                    {
                        Console.Write(tempPlayerCard.Suit + "-" + tempPlayerCard.Rank + "  ");
                    }
                    tempPlayerCard = tempPlayerCard.next;
                }
                Console.WriteLine();
                tempPlayer = tempPlayer.next;
            }
        }

        /// <summary>
        /// sort the card of all the player
        /// </summary>
        /// <param name="queuePlayer"></param>
        public static void Sort(QueuePlayer queuePlayer)
        {
            ListNodePlayer temp = queuePlayer.Front;
            while(temp != null)
            {
                SortCardQueue(temp.Data.queueCard);
                temp = temp.next;
            }
        }

        /// <summary>
        /// sort all the card of each of the player
        /// </summary>
        /// <param name="queueCard"></param>
        public static void SortCardQueue(QueueCard queueCard)
        {
            ListNodeCard current = queueCard.Front;
            ListNodeCard second = null;
            string tempSuit = null;
            int tempRank = 0;

            while(current != null)
            {
                second = current.next;
                while(second != null)
                {
                    if(current.Rank > second.Rank)
                    {
                        tempSuit = current.Suit;
                        tempRank = current.Rank;
                        current.Suit = second.Suit;
                        current.Rank = second.Rank;
                        second.Suit = tempSuit;
                        second.Rank = tempRank;
                    }
                    second = second.next;
                }
                current = current.next;
            }
        }

    }
}
