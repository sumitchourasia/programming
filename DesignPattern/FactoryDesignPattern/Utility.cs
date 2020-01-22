using System;

namespace DesignPattern.FactoryDesignPattern
{
    public static class Utility
    {
        /// <summary>
        /// Reads the int.
        /// </summary>
        /// <returns></returns>
        public static int ReadInt()
        {
            int input = 0;
            bool success = false;
            ////loop through the loop until user inputs the correct input
            while (true)
            {
                try
                {
                    success = int.TryParse(Console.ReadLine(), out input);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "try again");
                }
                if (success == true)
                {
                    return input;
                }
            }
        }

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns></returns>
        public static string ReadString()
        {
           string input = Console.ReadLine();
            return input;
        }
    }
}
