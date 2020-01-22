using System;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// abstract class (abstract) has to be extended and implentation has to be provided by the Implementation class  
    /// </summary>
    public abstract class Mobile
    {
        /// <summary>
        /// abstract method to Switch on the mobile
        /// </summary>
        public abstract void SwitchOn();
        /// <summary>
        /// abstract method to Switch off the mobile
        /// </summary>
        public abstract void SwitchOff();
        /// <summary>
        /// abstract method to Make the call.
        /// </summary>
        public abstract void MakeCall();
    }
}
