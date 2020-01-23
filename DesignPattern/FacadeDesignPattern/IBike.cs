using System;

namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// interface for bike type.
    /// </summary>
    interface IBike
    {
        /// <summary>
        /// Gets the petrol bike.
        /// </summary>
        public void GetPetrolBike();
        /// <summary>
        /// Gets the electric bike.
        /// </summary>
        public void GetElectricBike();
        /// <summary>
        /// Gets the cycle.
        /// </summary>
        public void GetCycle();
    }
}
