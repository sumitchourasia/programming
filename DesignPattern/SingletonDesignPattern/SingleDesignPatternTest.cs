using System;

namespace DesignPattern.SingletonDesignPattern
{
    /// <summary>
    /// class for singleton desing pattern
    /// </summary>
    public class SingleDesignPatternTest
    {
        /// <summary>
        /// operation for SingleDesignPatternTestMethod
        /// </summary>
        public void SingleDesignPatternTestMethod()
        {
            Console.WriteLine("Singleton Design Pattern");
            GetThreeInstance();
        }

        /// <summary>
        /// Gets the three instance.
        /// </summary>
        private static void GetThreeInstance()
        {
            string name = string.Empty;
            LazyInitializedSingleton obj;
            for(int i =0;i<3;i++)
            {
                Console.WriteLine("enter the name for the object : ");
                 name = Console.ReadLine();
                obj = LazyInitializedSingleton.GetInstance(name);
                if (obj != null)
                    Console.WriteLine("name : {0}",obj.Name);
                else
                    Console.WriteLine("object not created");
            }
        }
    }
}
