using System;

namespace DesignPattern.AdaptorDesignPattern
{
    /// <summary>
    /// volts class
    /// </summary>
    public class Volts
    {
        /// <summary>
        /// The volt instance variable
        /// </summary>
        public int volt ;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volts"/> class.
        /// </summary>
        public Volts()
        {
            this.volt = 220;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Volts"/> class.
        /// </summary>
        /// <param name="volt">The volt.</param>
        public Volts(int volt)
        {
            this.volt = volt;
        }

        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns></returns>
        public int GetVolts()
        {
            return this.volt;
        }

        /// <summary>
        /// Sets the volts.
        /// </summary>
        /// <param name="volt">The volt.</param>
        public void SetVolts(int volt)
        {
            this.volt = volt;
        }
    }
}
