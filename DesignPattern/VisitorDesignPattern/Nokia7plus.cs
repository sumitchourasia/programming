using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// class for item nokia7Plus that extends abstract class Mobile
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Mobile" />
    public class Nokia7plus : Mobile
    {
        private string item = "Nokia7plus";
       private int price;

        /// <summary>
        /// Initializes a new instance of the <see cref="Nokia7plus"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public Nokia7plus(int price)
        {
            this.price = price;
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <returns></returns>
        public string GetItem()
        {
            return this.item;
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
