using System;

namespace Logical
{
    class Gambler
    {
        int N ;
        int goal ;
        int stake;
        int bet ;
        int win ;
        int totalbets;
        int random = -1;
        bool compare = false;

        /// <summary>
        ///  the method starts the gambling and takes all the inputs from the playes and calls two methods 
        ///  CompareBet() and PrintResult()
        /// </summary>
        public void GamblerMethod()
        {
                Console.Write("enter the total number of times to play : ");
                N = Utility.Util.ReadInt();
                Console.Write("enter your goal : ");
                goal = Utility.Util.ReadInt();
                
                while (N > 0)
                {   
                      Console.WriteLine("N : "+N);
                      Console.Write("enter the Stake : ");
                      stake = Utility.Util.ReadInt();
                       
                        while (stake > 0 && goal > win)
                            {
                                totalbets++;
                                Console.WriteLine("remaining stake : {0}", stake);
                                Console.Write("place your bet (max = 10) : ");
                                bet = Utility.Util.ReadInt( );

                                compare=CompareBet( );

                                if(compare)
                                {
                                    stake++;
                                     win++;
                                }
                                else
                                {
                                    stake--;
                                }
                            }

                      if(goal == win )
                      {
                            break;
                      }

                 N--;
                }
                PrintResult();
        }

        /// <summary>
        /// Compares the generated number and tha bet made by player.
        /// </summary>
        /// <returns></returns>
        bool CompareBet()
        {
            Console.WriteLine("bet is  : {0}",this.bet);
            random = Utility.Util.GenerateRandomInteger(5);
            Console.WriteLine("random integer is  : {0}",random);
            
            if (bet == random)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prints the gambling result.
        /// </summary>
        void PrintResult()
        {
            Console.WriteLine("totalbets : {0}", totalbets);

            Console.WriteLine("bets won : {0}", win);

            Console.WriteLine("win percentage : {0}", ((double)win / totalbets) * 100);

            Console.WriteLine("loss percentage : {0}", ((double)(totalbets - win) / totalbets) * 100);
        }
    }

}
