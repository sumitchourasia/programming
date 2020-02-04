using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.DependencyInjection
{
    /// <summary>
    /// class to test the Dependency injection
    /// </summary>
    public class TestDependency
    {
        /// <summary>
        /// Dependency injection test method
        /// </summary>
        public void DependencyInjectionTest()
        {
            //// instantiate the sbi object
            SBI sbiObject = new SBI();

            //// instantiate the punjabnationalbank object
            PunjabNationalBank pnbObject = new PunjabNationalBank();

            Client client1 = new Client(sbiObject);

            Client client2 = new Client(pnbObject);

            ////calling the GetInterest method
            client1.GetInterest();
            client2.GetInterest();
        }
    }
}
