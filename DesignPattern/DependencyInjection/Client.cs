using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection
{
    /// <summary>
    /// client class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// instance variable of type IRBI
        /// </summary>
        private IRBI rbi;

        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="rbi">The rbi.</param>
        public Client(IRBI rbi )
        {
            this.rbi = rbi;
        }

        /// <summary>
        /// Gets the interest.
        /// </summary>
        public void GetInterest()
        {
            this.rbi.GetRateOfInterest();
        }
    }
}
