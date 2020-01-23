using System;

namespace DesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// ProxyRectangle class that implements the Ishape interface
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyDesignPattern.IShape" />
    public class ProxyRectangle : IShape
    {
        /// <summary>
        /// Ishape interface reference variable;
        /// </summary>
        IShape shape;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyRectangle"/> class.
        /// </summary>
        public ProxyRectangle()
        {

        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public void GetDetails()
        {
            shape = new Rectangle();
            shape.GetDetails();
        }

        /// <summary>
        /// Gets the area
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            shape = new Rectangle();
            return shape.GetArea();
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="breath">The breath.</param>
        /// <returns></returns>
        public double GetArea(double length , double breath)
        {
            shape = new Rectangle(length,breath);
            return shape.GetArea();
        }
    }
}
