using System;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// class to test Factory Class
    /// </summary>
    public class MobileFactoryTest
    {
        /// <summary>
        /// starts all the Operation
        /// </summary>
        public void MobileFactoryTestMethod()
        {
            try
            {
                Console.WriteLine("enter the name of the Mobile Type ( Nokia,Samsung,Apple) ");
                string type = Utility.ReadString();
                Mobile mobileObject = MobileFactory.CreateMobile(type);
                ////check if mobileObject is null to avoid nullpointer exception
                if (mobileObject != null)
                {
                    //// call the switch on method
                    mobileObject.SwitchOn();
                    ////call the makeCall method
                    mobileObject.MakeCall();
                    ////call the switch off method
                    mobileObject.SwitchOff();
                }
                else
                {
                    ////factory method createMobile returned null. 
                    Console.WriteLine("enter a valid Mobile type");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
