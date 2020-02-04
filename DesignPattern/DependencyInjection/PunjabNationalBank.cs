using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection
{
    /// <summary>
    /// class punjab national bank that implements the interface IRBI
    /// </summary>
    /// <seealso cref="DesignPattern.Dependency_Injection.IRBI" />
    public class PunjabNationalBank : IRBI
    {
        /// <summary>
        /// The rate of interest instance variable
        /// </summary>
        private double rateOfInterest;

        /// <summary>
        /// Initializes a new instance of the <see cref="PunjabNationalBank"/> class.
        /// </summary>
        public PunjabNationalBank()
        {
            rateOfInterest = 7.5;
        }

        /// <summary>
        /// method to get the Rates of interest.
        /// </summary>
        public void GetRateOfInterest()
        {
            Console.WriteLine("rate of interest of pubjab national bank is : {0}",this.rateOfInterest);
        }


    }
}
