using System;

namespace DataStructures
{
    class Program
    {
        static void Main( )
        {
            Console.WriteLine("enter your choice : ");
            Console.WriteLine(" 8 -> PrimeNumbersIn2D program ");
            Console.WriteLine(" 9 -> primeNumberAnagram2D program ");
            Console.WriteLine(" 3 -> ");

            int k = Utility.Util.ReadInt();

            switch(k)
            {
                    case 1:
                        
                        
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 8:
                        PrimeNumber2D prime = new PrimeNumber2D();
                        prime.PrimeNumber2DMethod();
                        break;

                    case 9:
                    PrimeNumberAnagram2D PrimeAnagram = new PrimeNumberAnagram2D();
                    PrimeAnagram.PrimeNumberAnagramMethod();
                    break;

                default :
                    Console.WriteLine("default run ");
                    break;
            }
        }
    }
}
