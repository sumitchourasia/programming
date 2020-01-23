using System;

namespace DesignPattern.ProxyDesignPattern
{
    interface IShape
    {
        /// <summary>
        /// Gets the details.
        /// </summary>
        public void GetDetails();

        /// <summary>
        /// Areas this instance.
        /// </summary>
        public double GetArea();
    }
}
