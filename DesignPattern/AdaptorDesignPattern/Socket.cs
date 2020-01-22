using System;

namespace DesignPattern.AdaptorDesignPattern
{
    /// <summary>
    /// socket class
    /// </summary>
    public class Socket
    {
        public Volts volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Socket"/> class.
        /// </summary>
        public Socket()
        {
            volts = new Volts();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Socket"/> class.
        /// </summary>
        /// <param name="volt">The volt.</param>
        public Socket(int volt)
        {
            volts = new Volts(volt);
        }

        /// <summary>
        /// returs the volts
        /// </summary>
        /// <returns></returns>
        public Volts GetSocket()
        {
            return this.volts;
        }

    }
}
