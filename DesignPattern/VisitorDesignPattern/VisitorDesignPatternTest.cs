using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// VisitorDesignPatternTest class to execute the Visitor Design Pattern program
    /// </summary>
    public class VisitorDesignPatternTest
    {
        /// <summary>
        /// VisitorDesignPatternTestMethod
        /// </summary>
        public void VisitorDesignPatternTestMethod()
        {
            Iproduct[] products = { new Nokia7plus(25000), new Apple6s(40000), new PeterEnglandShirt(2500), new LevisJeans(2900) };

            CheckOut(products);
        }
        /// <summary>
        /// Checks the out.
        /// </summary>
        /// <param name="productItems">The product items.</param>
        private static void CheckOut(Iproduct[] productItems)
        {
            IShopingCart shopingCartObject = new ShopingCartImpl();
            int sum = 0;
            foreach(Iproduct item in productItems)
            {
                sum = sum + item.ConnectToCart(shopingCartObject);
            }
            Console.WriteLine("sum total : {0}",sum);
        }

    }

   
}
