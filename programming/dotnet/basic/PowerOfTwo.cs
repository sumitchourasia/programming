using System;

namespace basic
{
    /// <summary>
    /// this class prints the table of power of two
    /// </summary>
    class PowerOfTwo
    {
        /// <summary>
        /// this method is used to take integer input as power and checks for its validation
        /// and calls FindPowerOfTwo method 
        /// </summary>
        public void PowerOfTwoMethod()
        {
            Console.WriteLine("enter the power : ");
            int power = Utility.Util.ReadInt();
            if(power>=0 && power <=31)
            {
                FindPowerOfTwo(ref power);
            }
            else
            {
                Console.WriteLine("power out of range");
            }
        }

        /// <summary>
        /// Finds the power of two.
        /// this method is used to print the table of power of two
        /// </summary>
        /// <param name="power">The power.</param>
        void FindPowerOfTwo( ref int power)
        {
            int i = 1;
            int baseValue = 2;
            int temp = 1;

            if (power == 0 )
            {
                Console.WriteLine("{0} to the power of {1} is : {2}", baseValue,power,temp);
            }
            else
            {   
                while(i<=power)
                {
                    temp = temp * baseValue;
                    Console.WriteLine("{0} to the power of {1} is : {2}", baseValue, i, temp);
                    i++;
                }
            }
        }


    }
}
