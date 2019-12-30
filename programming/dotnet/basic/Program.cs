using System;
using System.Collections.Generic;
using System.Text;

namespace basic
{
    /// <summary>
    /// this class is used as a driver class for all the other classes in ths basic namespace using switch case
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter your choice ");
            Console.WriteLine(" 1 -> Replace program ");
            Console.WriteLine(" 2 -> FlipCoin program ");
            Console.WriteLine(" 3 -> LeapYear program ");
            Console.WriteLine(" 4 -> PowerOf2 program ");
            Console.WriteLine(" 5 -> HarmonicNumber program ");
            Console.WriteLine(" 6 -> Factors program ");

            int choice = Utility.Util.ReadInt();

            switch(choice)
            {
                case 1:
                        Replace replace = new Replace();
                        replace.ReplaceWord();
                        break;                 
                          
                case 2:
                        FlipCoin fp = new FlipCoin();
                        fp.FlipCoinMethod();
                        break;

                case 3:
                        LeapYear lp = new LeapYear();
                        lp.LeapYearMethod();
                        break;
                    
                case 4:
                        PowerOfTwo pot = new PowerOfTwo();
                        pot.PowerOfTwoMethod();
                        break;

                case 5:
                        HarmonicNumber hn = new HarmonicNumber();
                        hn.HarmonicNumberMethod();
                        break;

                case 6:
                    Factors fact = new Factors();
                    fact.FactorMethod();
                    break;

                default:
                    Console.WriteLine("default run");
                    break;

            }




        }
    }
}
