using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// Abstract class that implements Iproduct interface
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Iproduct" />
    public abstract class Mobile : Iproduct
    {
        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns></returns>
        public abstract int GetPrice();
        /// <summary>
        /// Connects to cart.
        /// </summary>
        /// <param name="shopingCartObject">The shoping cart object.</param>
        /// <returns></returns>
        public abstract int ConnectToCart(IShopingCart shopingCartObject);

    }
}
