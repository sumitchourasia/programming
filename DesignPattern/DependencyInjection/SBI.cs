using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection
{
    /// <summary>
    /// SBI class that implements the IRBI Interface
    /// </summary>
    /// <seealso cref="DesignPattern.Dependency_Injection.IRBI" />
    public class SBI : IRBI
    {
        /// <summary>
        /// instance variableThe rate of interest
        /// </summary>
        private double rateOfInterest;
        /// <summary>
        /// Initializes a new instance of the <see cref="SBI"/> class.
        /// </summary>
        public SBI()
        {
            rateOfInterest = 8.5;
        }
        /// <summary>
        /// method to get Rates of interest.
        /// </summary>
        public void GetRateOfInterest()
        {
            Console.WriteLine("rate of interest is {0}",rateOfInterest);
        }
    }
}
