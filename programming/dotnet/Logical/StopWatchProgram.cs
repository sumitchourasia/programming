using System;


namespace Logical
{
    class StopWatchProgram
    {
        /// <summary>
        /// Method to take the input and call from the main function
        /// </summary>
        public void StopWatchMethod()
        {
                Console.WriteLine("Enter the time");
                int start = Convert.ToInt32(Console.ReadLine());
                int end = Convert.ToInt32(Console.ReadLine());
                Utility.Util.Stopwatch(start, end);
        }

    }
}
