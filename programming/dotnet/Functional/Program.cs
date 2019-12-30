using System;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice : ");
            Console.WriteLine(" 1 -> TwoDIntArray Program ");
            Console.WriteLine(" 2 -> sum of three integer adds to zero program ");
            Console.WriteLine(" 3 -> Euclidean Distance program ");
            Console.WriteLine(" 4 -> Quadratic roots program ");
            Console.WriteLine(" 5 -> WindChills Program ");
            Console.WriteLine(" ");

            int k = Utility.Util.ReadInt();

            switch(k)
            {
                case 1:
                    TwoDimensionalArray tda = new TwoDimensionalArray();
                    tda.TwoDIntArray();
                    break;

                case 2:
                    TripletSumZero tsz = new TripletSumZero();
                    tsz.TripletSumZeroMethod();
                    break;

                case 3:
                    EuclideanDistance ed = new EuclideanDistance();
                    ed.EuclideanDistanceMethod();
                    break;

                case 4:
                    QuadraticRoots qr = new QuadraticRoots();
                    qr.QuadraticRootsMethod();
                    break;

                case 5:
                    WindChills wc = new WindChills();
                    wc.WindChillsMethod();
                    break;

                default:
                    Console.WriteLine("invalid selection");
                    break;

            }


        }
    }
}
