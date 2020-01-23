using System;

namespace DesignPattern.FacadeDesignPattern
{
    /// <summary>
    /// FacadeShopping class for FacadeDesignPattern
    /// </summary>
    class FacadeShoping 
    {
        Car carObj;
        Bike bikeObj;
        /// <summary>
        /// Initializes a new instance of the <see cref="FacadeShoping"/> class.
        /// </summary>
        public FacadeShoping()
        {
            carObj = new Car();
            bikeObj = new Bike();
        }

        /// <summary>
        /// Orders the petrol car.
        /// </summary>
        public void OrderPetrolCar()
        {
            carObj.GetPetrolCar();
        }
        /// <summary>
        /// Orders the deisel car.
        /// </summary>
        public void OrderDeiselCar()
        {
            carObj.GetDeiselCar();
        }
        /// <summary>
        /// Orders the electric car.
        /// </summary>
        public void OrderElectricCar()
        {
            carObj.GetElectricCar();
        }

        /// <summary>
        /// Orders the cycle.
        /// </summary>
        public void OrderCycle()
        {
            bikeObj.GetCycle();
        }
        /// <summary>
        /// Orders the petrol bike.
        /// </summary>
        public void OrderPetrolBike()
        {
            bikeObj.GetPetrolBike();
        }
        /// <summary>
        /// Orders the electric bike.
        /// </summary>
        public void OrderElectricBike()
        {
            bikeObj.GetElectricBike();
        }

    }
}
