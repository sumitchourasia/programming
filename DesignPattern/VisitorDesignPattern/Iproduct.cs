using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// Iproduct interface
    /// </summary>
    public interface Iproduct
    {
        /// <summary>
        /// Connects to cart.
        /// </summary>
        /// <param name="shopingCartObject">The shoping cart object.</param>
        /// <returns></returns>
        public int ConnectToCart(IShopingCart shopingCartObject);
    }
}
