using System;

namespace DesignPattern
{
    /// <summary>
    /// class that contains the main method
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main( )
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1 -> Singleton design pattern ");
            Console.WriteLine("2 -> FactoryDesignPattern ");
            Console.WriteLine("3 -> Prototype Design Pattern ");
            Console.WriteLine("4 -> Adaptor Design pattern ");
            Console.WriteLine("5 -> Facade Design Pattern ");
            Console.WriteLine("6 -> Proxy Design Pattern ");
            Console.WriteLine("7 -> Observer Design Pattern ");
            Console.WriteLine("8 -> Visitor Design Pattern");
            //// take the input from the user
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                   
                    break;
                case 2:
                    ////to execute the factoryDesignPattern program.
                    FactoryDesignPattern.MobileFactoryTest factoryDesignObject = new FactoryDesignPattern.MobileFactoryTest();
                    factoryDesignObject.MobileFactoryTestMethod();
                    break;
                case 3:
                    ////to execute the Prototype Design Pattern program
                    PrototypeDesignPattern.PrototypeDesignPattern prototypeObject = new PrototypeDesignPattern.PrototypeDesignPattern();
                    prototypeObject.PrototypeDesignPatternMethod();
                    break;
                case 4:
                    ////to execute the Adaptor Design Pattern program
                    AdaptorDesignPattern.AdaptorDesignPatternTest adaptorDesignObject = new AdaptorDesignPattern.AdaptorDesignPatternTest();
                    adaptorDesignObject.AdaptorDesignPatternTestMethod();
                    break;
                case 5:
                    ////to execute the Facade Design Pattern program
                    FacadeDesignPattern.FacadeDesignPatternTest facadeDesignObject = new FacadeDesignPattern.FacadeDesignPatternTest();
                    facadeDesignObject.FacadeDesignPatternTestMethod();
                    break;
                case 6:
                    ////to execute the proxy design pattern program
                    ProxyDesignPattern.ProxyDesignPatternTest proxyObject = new ProxyDesignPattern.ProxyDesignPatternTest();
                    proxyObject.ProxyDesignPatternTestMethod();
                    break;
                case 7:
                    ObserverDesignPattern.ObserverDesignPatternTest observerPatternObject = new ObserverDesignPattern.ObserverDesignPatternTest();
                    observerPatternObject.Display();
                    break;
                case 8:
                    VisitorDesignPattern.VisitorDesignPatternTest visitorDPObject = new VisitorDesignPattern.VisitorDesignPatternTest();
                    visitorDPObject.VisitorDesignPatternTestMethod();
                    break;
                default :
                    Console.WriteLine("default case");
                    break;
            }
        }
    }      
}
