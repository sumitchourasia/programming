using System;

namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// Bike class implements the IBike interface
    /// </summary>
    public class Bike : IBike
    {
        /// <summary>
        /// Gets the petrol bike.
        /// </summary>
        public void GetPetrolBike()
        {
            Console.WriteLine("successfully registered for the Petrol Bike");
        }
        /// <summary>
        /// Gets the electric bike.
        /// </summary>
        public void GetElectricBike()
        {
            Console.WriteLine("successfully registered for the Electric Bike");
        }
        /// <summary>
        /// Gets the cycle.
        /// </summary>
        public void GetCycle()
        {
            Console.WriteLine("successfully registered for the cycle");
        }
    }
}
