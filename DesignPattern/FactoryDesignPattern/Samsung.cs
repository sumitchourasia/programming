using System;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// Samsung class extends abstract class Mobile and provides the implementation
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.Mobile" />
    class Samsung : Mobile
    {
        /// <summary>
        /// Switch on the mobile
        /// </summary>
        public override void SwitchOn()
        {
            Console.WriteLine("Switching On Samsung!!!");
        }
        /// <summary>
        /// Switch off the mobile
        /// </summary>
        public override void SwitchOff()
        {
            Console.WriteLine("Switching Off Samsung!!!");
        }

        /// <summary>
        /// Makes the call.
        /// </summary>
        public override void MakeCall()
        {
            Console.WriteLine("making call Samsung!!!");
        }
    }
}
