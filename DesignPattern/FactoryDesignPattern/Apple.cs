using System;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// Apple class extends abstract class Mobile and provides the implementation
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.Mobile" />
    class Apple : Mobile
    {
        /// <summary>
        /// Switch on the mobile
        /// </summary>
        public override void SwitchOn()
        {
            Console.WriteLine("Switching On Apple!!!");
        }
        /// <summary>
        /// Switch off the mobile
        /// </summary>
        public override void SwitchOff()
        {
            Console.WriteLine("Switching Off Apple!!!");
        }
        /// <summary>
        /// Makes the call.
        /// </summary>
        public override void MakeCall()
        {
            Console.WriteLine("making call Apple!!!");
        }
    }
}
