using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BankingCashCounter
{
    class BankingCashCounter<T>
    {
        public void BankingMethod()
        {
            int balance = 10000;
            Queue<int> Q = Utility.CreateQueue<int>();

            do
            {
                Console.Write("enter your choice : ");
                Console.WriteLine(" 1 -> Enque ");
                Console.WriteLine(" 2 -> Deque ");
                Console.WriteLine(" 3 -> stop ");

                int k = Utility.ReadInt();

                Console.WriteLine("enter the amount");
                int amount = Utility.ReadInt();

                switch (k)
                {
                    case 1:
                        Console.WriteLine("Enque :");

                        Utility.Enque<int>(Q, amount);
                        break;

                    case 2:
                        Console.WriteLine("Deque : ");
                        Console.WriteLine("1 -> deposit");
                        Console.WriteLine("2 -> withdraw");
                        int ch = Utility.ReadInt();
                        if (ch == 1)
                            balance += amount;
                        else if (ch == 2)
                            balance -= amount;
                        Utility.Deque<int>(Q);
                        break;

                    case 3:
                        Console.WriteLine("Thank you");
                        break;
                }

            } while (true);

        }
    }
}

