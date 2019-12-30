using System;

namespace basic
{
    /// <summary>
    /// this class prints the percentage of heads upon tossing a coin for given number of times
    /// </summary>
    class FlipCoin
    {
        /// <summary>
        /// Flips the coin method.
        /// this method is used to take input from user and call the percentageOfHead method and print the
        /// returned value
        /// </summary>
        public void FlipCoinMethod()
        {
            
            Console.WriteLine("enter the no of times to flip the coin ");

            int times = Utility.Util.ReadInt();

            double headpercentage = PercentageOfHead(times);

            Console.WriteLine("head percentage : {0}", headpercentage);
            Console.WriteLine("tail percentage : {0}", 100 - headpercentage);
            
        }


        /// <summary>
        /// Percentages the of head.
        /// this method takes int input no of times and retuns percentage of heads that appear
        /// </summary>
        /// <param name="times">The times.</param>
        /// <returns></returns>
         double PercentageOfHead(int times)
        {
            int i = 1;
            int heads = 0;
            Random rd = new Random();
            int random = 0;
            while (i<=times)
            {
                random = rd.Next(0, 2);

                if (random == 1)
                {
                    heads++;
                }

                i++;
            }

            double headpercentage = ((double)heads / times) * 100 ;

            return headpercentage;
        }
    }
}
