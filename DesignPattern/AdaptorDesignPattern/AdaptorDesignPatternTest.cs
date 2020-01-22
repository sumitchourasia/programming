using System;

namespace DesignPattern.AdaptorDesignPattern
{
    /// <summary>
    /// method to execute all the operation
    /// </summary>
    public class AdaptorDesignPatternTest
    {
        /// <summary>
        /// executes the Adaptordesignpatterntestmethod.
        /// </summary>
        public void AdaptorDesignPatternTestMethod()
        {
            //// Instantiate SocketAdaptorImpl class object 
            SocketAdaptorImpl socketImplObject = new SocketAdaptorImpl();
            ////call various methods using the socketImplobject
                 Volts volt5 = socketImplObject.Get5Volts();
                 Volts volt110 =  socketImplObject.Get110Volts();
                 Volts volt220 = socketImplObject.Get220Volts();
            ////print all the values
            Console.WriteLine(" volts : "+ volt5.GetVolts());
            Console.WriteLine(" volts : " + volt110.GetVolts());
            Console.WriteLine(" volts : " + volt220.GetVolts());
        }
    }
}
