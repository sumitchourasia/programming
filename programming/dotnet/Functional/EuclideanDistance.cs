using System;

namespace Functional
{
    /// <summary>
    /// this class calculates the Euclidean distace when given two co-ordinates.
    /// </summary>
    class EuclideanDistance
    {

        /// <summary>
        /// Euclidean distance method to take in the input co-ordinate and call the method FindEuclideanDistance
        /// and print the distance.
        /// </summary>
        public void EuclideanDistanceMethod()
        {
            //enter the first co-ordinate
            Console.WriteLine("enter the vlaues of X1 and Y1 : ");
            int x1 = Utility.Util.ReadInt();
            int y1 = Utility.Util.ReadInt();

            //enter the second co-ordinate
            Console.WriteLine("enter the vlaues of X2 and Y2 : ");
            int x2 = Utility.Util.ReadInt();
            int y2 = Utility.Util.ReadInt();

            //calling method to calculate the Euclidean distance
            double distance = FindEuclideanDistance(x1,y1,x2,y2);

            Console.WriteLine("Euclidean Distance is : {0}",distance);

        }


        /// <summary>
        /// Finds the Euclidean distance.
        /// take in 2 co-ordinates and calculates the distance and returns a double distance value
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <returns>double Euclidean distance</returns>
        static double FindEuclideanDistance(int x1,int y1,int x2,int y2)
        {

            return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2 - y1), 2));
        }



    }
}
