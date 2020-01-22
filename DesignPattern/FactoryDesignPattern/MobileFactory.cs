using System;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// factory class
    /// </summary>
    public class MobileFactory
    {
        /// <summary>
        /// Factory method to check and return the corresponding object
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static Mobile CreateMobile(string type)
        {
            ////check the type of object that is required
            if (type.Equals("Nokia"))
                return new Nokia();
            else if (type.Equals("Apple"))
                return new Apple();
            else if (type.Equals("Samsung"))
                return new Samsung();
            else
                return null;
        }
    }
}
