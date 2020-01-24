using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// Class PeterEnglandShirt
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Cloth" />
    public class PeterEnglandShirt : Cloth
    {
        private int price;
        private string item = "PeterEnglandShirt";
        /// <summary>
        /// Initializes a new instance of the <see cref="PeterEnglandShirt"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public PeterEnglandShirt(int price)
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
        /// Gets the item.
        /// </summary>
        /// <returns></returns>
        public string GetItem()
        {
            return this.item;
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
