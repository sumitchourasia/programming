using System;

namespace DesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// ProxyCircle class to provide limited functionalities
    /// </summary>
    /// <seealso cref="DesignPattern.ProxyDesignPattern.IShape" />
    public class ProxyCircle : IShape
    {
        IShape shape;
        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyCircle"/> class.
        /// </summary>
        public ProxyCircle()
        {
            
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        public void GetDetails()
        {
            shape = new Circle();
            shape.GetDetails();
        }
       
        /// <summary>
        /// Gets the area.
        /// </summary>
        public double GetArea()
        {
            shape = new Circle();
            return shape.GetArea(); 
        }
        /// <summary>
        /// Gets the area.
        /// </summary>
        public double GetArea(double radius)
        {
            shape = new Circle(radius);
            return shape.GetArea();
        }

    }
}
