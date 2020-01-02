using System;

namespace Functional
{
    /// <summary>
    /// class to call store and display the the different types of array i.e integer ,double ,boolean array.
    /// </summary>
    class TwoDimensionalArray
    {
        /// <summary>
        ///this method lets user select the choice of array (using switch cases) 
        ///and then takes in the array element and prints it.
        /// </summary>
        public void TwoDIntArray( )
        {
           
            while (true)
            {
                Console.WriteLine("select which array u want :");
                Console.WriteLine("1 -> integer array ");
                Console.WriteLine("2 -> double array ");
                Console.WriteLine("3 -> boolean array ");

                int k = Utility.Util.ReadInt();

                switch (k)
                {
                    case 1:
                        int[,] intarr = new int[3, 3];
                        Console.WriteLine("enter into integer array");
                        Utility.Util.InputTwoDIntArray(intarr);
                        Console.WriteLine("print Two DImensional integer array");
                        Utility.Util.PrintTwoDIntArray(intarr);
                        continue;

                    case 2:
                        double[,] doublearr = new double[3, 3];
                        Console.WriteLine("enter into double array");
                        Utility.Util.InputTwoDDoubleArray(doublearr);
                        Console.WriteLine("print Two DImensional Double array");
                        Utility.Util.PrintTwoDDoubleArray(doublearr);
                        continue;

                    case 3:
                        bool[,] boolarr = new bool[3, 3];
                        Console.WriteLine("enter into Boolean array");
                        Utility.Util.InputTwoDBooleanArray(boolarr);
                        Console.WriteLine("print Two Dimensional Boolean array");
                        Utility.Util.PrintTwoDBooleanArray(boolarr);
                        continue;

                    default:
                        Console.WriteLine("invalid choice");
                        return;
                }
            }


        }

    }
}
