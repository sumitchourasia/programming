using System;

namespace Functional
{
    /// <summary>
    /// this class is to calculate wind chills 
    /// class has ome instance method called WindChillsMethod() and a static method called CalculateWindChills() 
    /// </summary>
    class WindChills
    {
        public void WindChillsMethod()
        {
            //input temperature and check for validation
            Console.WriteLine("enter the temperature(less than 50) in farhenheit : ");
            double t = Utility.Util.ReadInt();
            if (Math.Abs(t) > 50)
            {
                Console.WriteLine("temperature must be less than or equal to 50F ");
                return;
            }

            //input wind velocity and check for validation
            Console.WriteLine(" enter the velocity of wind(in between 3-120 miles/h) ");
            double v = Utility.Util.ReadInt();
            if (v < 3 || v > 120)
            {
                Console.WriteLine("velocity must be in between 3 and 120 miles/hours");
                return;
            }
           
            //call the method to calculate the wind chills
            double w = CalculateWindChills(t, v);
            Console.WriteLine("wind chills : {0}", w);
            
        }

        /// <summary>
        /// Calculates the wind chills.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="v">The v.</param>
        /// <returns> double variable w</returns>
        static double CalculateWindChills(double t,double v)
        {
            double w = (35.74 + (0.6215 * t) * ((0.4275 * t) - 35.75) * Math.Pow(v, 16));
           
            return w;
        }

    }
}
