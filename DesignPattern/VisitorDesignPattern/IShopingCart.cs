using System;

namespace DesignPattern.VisitorDesignPattern
{
    /// <summary>
    /// Interface with all operation of similar objects at one place
    /// </summary>
    public interface IShopingCart
    {
        /// <summary>
        /// Visits the specified peter England shirt object.
        /// </summary>
        /// <param name="peterEnglandShirtObj">The peter england shirt object.</param>
        /// <returns></returns>
        public int Visit(PeterEnglandShirt peterEnglandShirtObj);
        /// <summary>
        /// Visits the specified levis jeans object.
        /// </summary>
        /// <param name="levisJeansObj">The levis jeans object.</param>
        /// <returns></returns>
        public int Visit(LevisJeans levisJeansObj);
        /// <summary>
        /// Visits the specified nokia7plus object.
        /// </summary>
        /// <param name="Nokia7plusObj">The nokia7plus object.</param>
        /// <returns></returns>
        public int Visit(Nokia7plus Nokia7plusObj);
        /// <summary>
        /// Visits the specified apple6s obj.
        /// </summary>
        /// <param name="apple6Sobj">The apple6 sobj.</param>
        /// <returns></returns>
        public int Visit(Apple6s apple6Sobj);

    }
}
