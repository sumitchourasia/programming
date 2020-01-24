using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// calss for Item Apple6s
    /// </summary>
    /// <seealso cref="DesignPattern.VisitorDesignPattern.Mobile" />
    public class Apple6s : Mobile
    {
        private string item = "Apple6s";
        private int price;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Apple6s"/> class.
        /// </summary>
        /// <param name="price">The price.</param>
        public Apple6s(int price)
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
