using System;

namespace basic
{
    /// <summary>
    /// class to calculate the harmonic progression
    /// </summary>
    class HarmonicNumber
    {
        /// <summary>
        /// method to take input from user and call FIndHArmopnicProgression method and prints the returned value.
        /// </summary>
        public void HarmonicNumberMethod()
        {
            Console.WriteLine("enter the number for which harmonic number has to be found");
            int number = Utility.Util.ReadInt();

            //input validation
            if(number>0)
            {
                //call method and store the returned value in local variable.
                double harmonic = FindHarmonicNumber(number);
                Console.WriteLine("harmonic number for {0} is {1}",number,harmonic);
            }
            else
            {
                Console.WriteLine("enter a natural value");
            }
        }

        /// <summary>
        /// method to Find the harmonic progression 
        /// it takes integer as a paramter and returns a double.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        double FindHarmonicNumber(int number)
        {
            int i = 1;
            double harmonic = 0.0;
            
            while(i<=number)
            {
                harmonic = (harmonic + ((double)1 / i));
                i++;
            }

            return harmonic;
        }
    }
}
