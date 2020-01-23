using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPattern
{
    public class Rectangle : IShape
    {
        private double length;
        private double breath;

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public double Length { get => this.length; set => this.length = value; }

        /// <summary>
        /// Gets or sets the breath.
        /// </summary>
        /// <value>
        /// The breath.
        /// </value>
        public double Breath { get => this.breath; set => this.breath = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle()
        {
            this.length = 5;
            this.breath = 5;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="breath">The breath.</param>
        public Rectangle(double length,double breath)
        {
            this.length = length;
            this.breath = breath;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        public void GetDetails()
        {
            Console.WriteLine("this is a rectangle");
        }

        /// <summary>
        /// Gets the arear.
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return (this.length * this.breath);
        }

    }
}
