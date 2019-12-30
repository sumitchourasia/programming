using System;

namespace basic
{
    class HarmonicNumber
    {
        public void HarmonicNumberMethod()
        {
            Console.WriteLine("enter the number for which harmonic number has to be found");
            int number = Utility.Util.ReadInt();
            if(number>0)
            {
                double harmonic = FindHarmonicNumber(number);
                Console.WriteLine("harmonic number for {0} is {1}",number,harmonic);
            }
            else
            {
                Console.WriteLine("enter a natural value");
            }
        }

        double FindHarmonicNumber(int number)
        {
            int i = 1;
            double harmonic = 0.0;
            
            while(i<=number)
            {
                harmonic = (harmonic + ((double)1 / i));
                i++;
            }

            return harmonic;
        }
    }
}
