using System;

namespace JUnit
{
    /// <summary>
    /// this class is used to take the amount from user and provide the user with minimum number of notes
    /// and also prints the notes of all the denomination.
    /// </summary>
    class VendingMachine
    {
        public void VendingMachineMethod()
        {
            Console.WriteLine("enter the amount to get the change : ");
            int money = Utility.Util.ReadInt();

            //12763
            int totalnotes = GetChangeRecusion(money,1000,0);
            Console.WriteLine("total notes are : {0}",totalnotes);
            //getChange(money);

        }

        /// <summary>
        /// Gets the change using iterative method.
        /// </summary>
        /// <param name="money">The total amount is passed as argument.</param>
        void getChange(int money)
        {
            int amount = money;
            int domination = 1000;
            int notes = 0;
            int totalnotes = 0;

            while(amount>=1)
            {
                notes = amount / domination;
                amount = amount % domination;
                totalnotes += notes;

                if (notes != 0)
                {
                    Console.WriteLine("{0} ruppes notes are : {1}", domination, notes);
                }

                if (domination == 500 || domination == 50)
                {
                    domination = domination / 5;
                }
                else
                {
                    domination = domination / 2;
                }
            }

            Console.WriteLine("total number of notes are : {0}",totalnotes);
        }

        /// <summary>
        /// Gets the change using recusion.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <param name="denomination">The denomination.</param>
        /// <param name="totalnotes">The totalnotes.</param>
        /// <returns></returns>
        int GetChangeRecusion(int amount,int denomination,int totalnotes)
        {
           
            if (amount<1)
            {
                return totalnotes;
            }
            else
            {
               
                int notes = amount / denomination;
                amount = amount % denomination;
                totalnotes += notes;

                if(notes!=0)
                Console.WriteLine(" {0} ruppees notes are : {1}",denomination,notes);

                if (denomination == 500 || denomination == 50)
                {
                    denomination = denomination / 5;
                }
                else
                {
                    denomination = denomination / 2;
                }

                totalnotes=GetChangeRecusion(amount,denomination,totalnotes);

                return totalnotes;
            }

        }




    }
}












