using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// abstract class cloth that implements IProduct interface
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Iproduct" />
    public abstract class Cloth : Iproduct
    {
        /// <summary>
        /// Connects to cart.
        /// </summary>
        /// <param name="shopingCartObject">The shoping cart object.</param>
        /// <returns></returns>
        public abstract int ConnectToCart(IShopingCart shopingCartObject);
        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns></returns>
        public abstract int GetPrice();
    }
}
