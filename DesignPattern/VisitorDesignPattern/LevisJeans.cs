using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// LevisJeans class
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Cloth" />
    public class LevisJeans : Cloth
    {
        private int price;
        /// <summary>
        /// Initializes a new instance of the <see cref="LevisJeans"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public LevisJeans( int price)
        {
            this.price = price;
        }
        /// <summary>
        /// Gets the price.
        /// </summary>
        /// <returns></returns>
        public override int GetPrice()
        {
            return this.price;
        }
        /// <summary>
        /// Connects to cart.
        /// </summary>
        /// <param name="shopingCartObject">The shoping cart object.</param>
        /// <returns></returns>
        public override int ConnectToCart(IShopingCart shopingCartObject)
        {
            return shopingCartObject.Visit(this);
        }
    }
}
