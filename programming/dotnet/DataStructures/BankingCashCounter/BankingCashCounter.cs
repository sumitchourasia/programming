using System;

using System.Text;

namespace DataStructures.BankingCashCounter
{
    /// <summary>
    /// implemtenting Banking Cash Counter Program
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class BankingCashCounter<T>
    {
        /// <summary>
        /// method to start the opertaion
        /// </summary>
        public void BankingMethod()
        {
            int balance = 10000;
            Queue<int> Q = Utility.CreateQueue<int>();
            int select = 0;
            int amount = 0;
            int person = 0;
            int choice = 0;
            ////do-while loop.
            do
            {
                Console.Write("enter your choice : ");
                Console.WriteLine(" 1 -> Enque ");
                Console.WriteLine(" 2 -> Deque ");
                Console.WriteLine(" 3 -> stop ");
                select = Utility.ReadInt();
               
                ////switch case for enque or deque
                switch (select)
                {
                    case 1:
                        //// take the persons  choice to deposit or withdraw and take the amount
                        
                        Console.WriteLine("Enque :");

                        ////enter the amount in the queue
                        Utility.Enque<int>(Q, ++person);
                        break;

                    case 2:
                        ////deque 
                        Console.WriteLine("deque");
                        
                        int Lineperson = Utility.Deque<int>(Q);

                        if(Lineperson == -1)
                        {
                            Console.WriteLine("empty queue ");
                            break;
                        }

                        Console.WriteLine("person : {0}",Lineperson);

                        choice = OperationToPerform();

                        Console.Write("enter the amount : ");
                        amount = Utility.ReadInt();

                        //// 1 : deposit and 2 : withdraw
                        if (choice == 1) 
                        {
                            balance += amount; 
                        }
                        else if (choice == 2)
                        {
                            if (amount > balance)
                            {
                                Console.WriteLine("not possible now");
                                break;
                            }
                            else
                            {
                                balance -= amount;
                            }
                        }

                        Console.WriteLine("balance : {0}",balance);
                        break;

                    case 3:
                        Console.WriteLine("balance  is : {0}", balance);
                        Console.WriteLine("Thank you");
                        return;

                    default :
                        Console.WriteLine("invalide selection try again");
                        break;
                }

            } while (select != 1 || select != 2 && select != 3);

           

        }

        int OperationToPerform()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("1 -> deposit");
                Console.WriteLine("2 -> withdraw");
                choice = Utility.ReadInt();

            } while (choice != 1 && choice != 2);
           
            return choice;
        }

    }

}

