using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// Implementation class for interface Ishoping
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.IShopingCart" />
    public class ShopingCartImpl : IShopingCart
    {
        /// <summary>
        /// Visits the specified peterEnglandShirt object.
        /// </summary>
        /// <param name="pesObj">The pes object.</param>
        /// <returns></returns>
        public int Visit(PeterEnglandShirt pesObj)
        {
           return pesObj.GetPrice();
        }

        /// <summary>
        /// Visits the specified levis object.
        /// </summary>
        /// <param name="levisObj">The levis object.</param>
        /// <returns></returns>
        public int Visit(LevisJeans levisObj)
        {
           return levisObj.GetPrice();
        }

        /// <summary>
        /// Visits the specified nokia object.
        /// </summary>
        /// <param name="nokiaObj">The nokia object.</param>
        /// <returns></returns>
        public int Visit(Nokia7plus nokiaObj)
        {
            return nokiaObj.GetPrice();
        }

        /// <summary>
        /// Visits the specified apple object.
        /// </summary>
        /// <param name="appleObj">The apple object.</param>
        /// <returns></returns>
        public int Visit(Apple6s appleObj)
        {
            return appleObj.GetPrice();
        }
    }
}
