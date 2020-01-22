using System;

namespace DesignPattern.AdaptorDesignPattern
{
    /// <summary>
    /// class extends Socket Class and implements IsocketAdapter
    /// </summary>
    /// <seealso cref="DesignPattern.AdaptorDesignPattern.Socket" />
    /// <seealso cref="DesignPattern.AdaptorDesignPattern.ISocketAdaptor" />
    public class SocketAdaptorImpl : Socket, ISocketAdaptor
    {
        /// <summary>
        /// Gets 220 volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get220Volts()
        {
            return new Volts();
        }

        /// <summary>
        /// Gets 110 volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get110Volts()
        {
            Volts volt = new Volts();
            return ConvertVolts(volt,2);
        }

        /// <summary>
        /// Gets 3 volts.
        /// </summary>
        /// <returns></returns>
        public Volts Get5Volts()
        {
            Volts volt = new Volts();
            return ConvertVolts(volt,40);
        }

        /// <summary>
        /// Converts the volts.
        /// </summary>
        /// <param name="volt">The volt.</param>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public Volts ConvertVolts( Volts volt,int i)
        {
            return new Volts(volt.GetVolts()/i);
        }
    }
}
