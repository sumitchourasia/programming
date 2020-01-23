using System;

namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// Interface for car types selection
    /// </summary>
    interface ICar
    {
        /// <summary>
        /// Gets the deisel car.
        /// </summary>
        public void GetDeiselCar();

        /// <summary>
        /// Gets the petrol car.
        /// </summary>
        public void GetPetrolCar();

        /// <summary>
        /// Gets the electric car.
        /// </summary>
        public void GetElectricCar();
    }
}
