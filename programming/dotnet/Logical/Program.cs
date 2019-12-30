using System;

namespace Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your choice : ");
            Console.WriteLine(" 1 -> Gambler Program ");
            Console.WriteLine(" 2 -> Coupon Number Program");
            Console.WriteLine(" 3 -> Simulate StopWatch program ");
            Console.WriteLine(" 4 -> tic-tac-toe Game program ");
            Console.WriteLine(" ");

            int k = Utility.Util.ReadInt();
            Console.WriteLine(" ");

            switch (k)
            {
                case 1:
                    Gambler gambler = new Gambler();
                    gambler.GamblerMethod();
                    break;

                case 2:
                    CouponNumbers cn = new CouponNumbers();
                    cn.CouponNumberMethod();
                    break;

                case 3:
                    
                    break;

                case 4:
                    TicTacToe ttt = new TicTacToe();
                    ttt.TicTacToeMethod();
                    break;

                default:
                    Console.WriteLine("invalid selection");
                    break;
            }
        }
    }
}
