using System;

namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// car class implements the Icar interface
    /// </summary>
    /// <seealso cref="DesignPattern.FacadeDesignPattern.ICar" />
    public class Car : ICar
    {
        /// <summary>
        /// Gets the deisel car.
        /// </summary>
        public void GetDeiselCar()
        {
            Console.Write("successfully registered for Deisel car");
        }
        /// <summary>
        /// Gets the petrol car.
        /// </summary>
        public void GetPetrolCar()
        {
            Console.WriteLine("successfully registered for petrol car");
        }
        /// <summary>
        /// Gets the electric car.
        /// </summary>
        public void GetElectricCar()
        {
            Console.WriteLine("successfully registered for Electric car");
        }

    }
}
