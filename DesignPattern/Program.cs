using System;

namespace DesignPattern
{
    /// <summary>
    /// class that contains the main method
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1 -> Singleton design pattern ");
            Console.WriteLine("2 -> FactoryDesignPattern ");
            //// take the input from the user
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ////to execute the factoryDesignPattern program.
                    FactoryDesignPattern.MobileFactoryTest factoryDesignObject = new FactoryDesignPattern.MobileFactoryTest();
                    factoryDesignObject.MobileFactoryTestMethod();
                    break;
                case 2:

                    break;
            }
        }
    }
}
