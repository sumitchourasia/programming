using System;

namespace DesignPattern.AdaptorDesignPattern
{
    /// <summary>
    /// Interface for socket and adapter
    /// </summary>
    interface ISocketAdaptor
    {
        /// <summary>
        /// Get220s the volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get220Volts();
        /// <summary>
        /// Get110s the volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get110Volts();
        /// <summary>
        /// Get3s the volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get5Volts();
           
    }
}
