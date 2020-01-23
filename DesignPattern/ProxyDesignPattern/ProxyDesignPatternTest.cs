using System;

namespace DesignPattern.ProxyDesignPattern
{
    /// <summary>
    /// ProxyDesignPatternTest class
    /// </summary>
    public class ProxyDesignPatternTest
    {
        /// <summary>
        /// ProxyDesignPatternTestMethod.
        /// </summary>
        public void ProxyDesignPatternTestMethod()
        {
            while (true)
            {
                Console.Write("enter your choice : ");
                Console.WriteLine(" 1 -> proxyRectangle");
                Console.WriteLine(" 2 -> proxyCircle");
                Console.WriteLine(" 3 -> stop");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ProxyRectangle rectangleObj = new ProxyRectangle();
                        rectangleObj.GetDetails();
                        Console.WriteLine("area of rectangle(default) : {0}", rectangleObj.GetArea());
                        Console.WriteLine("enter the length and breath : ");
                        Console.WriteLine("area of rectangle(parameterized) : {0}", rectangleObj.GetArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
                        break;
                    case 2:
                        ProxyCircle circleObj = new ProxyCircle();
                        circleObj.GetDetails();
                        Console.WriteLine("circle area(default) : {0}", circleObj.GetArea());
                        Console.WriteLine("enter the radius :");
                        Console.WriteLine("area of the circle(parameterized) {0}",circleObj.GetArea(Convert.ToDouble(Console.ReadLine())));
                        break;
                    case 3:
                        return;
                }
            }
        }
    }
}
