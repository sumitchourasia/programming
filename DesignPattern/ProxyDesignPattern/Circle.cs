using System;

namespace DesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// class circle implements IShape interface
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyDesignPattern.IShape" />
    public class Circle : IShape
    {
        private double radius;
        private const double PI = 3.14;
        public double Radius { get => this.radius; set => this.radius = value; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle()
        {
            this.radius = 5.0;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius.</param>
        public Circle (double radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("this is an actual circle");
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
           return ( PI * this.radius * this.radius);
        }
    }
}
