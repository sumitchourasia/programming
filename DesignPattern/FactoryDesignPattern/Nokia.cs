using System;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// Nokia class extends abstract class Mobile and provides the implementation
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.Mobile" />
    class Nokia : Mobile
    {
        /// <summary>
        /// Switch on the mobile
        /// </summary>
        public override void SwitchOn()
        {
            Console.WriteLine("Switching On Nokia!!!");
        }
        /// <summary>
        /// Switch off the mobile
        /// </summary>
        public override void SwitchOff()
        {
            Console.WriteLine("Switching Off nokia!!!");
        }
        /// <summary>
        /// Makes the call.
        /// </summary>
        public override void MakeCall()
        {
            Console.WriteLine("making call from nokia!!!");
        }
    }
}
