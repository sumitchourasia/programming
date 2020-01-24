using System;

namespace DesignPattern.SingletonDesignPattern
{
    /// <summary>
    /// class for LazyInitializedSingleton pattern
    /// </summary>
    public class LazyInitializedSingleton
    {
        private string name ;
        private static LazyInitializedSingleton obj;
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LazyInitializedSingleton"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        private LazyInitializedSingleton(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static LazyInitializedSingleton GetInstance(string name)
        {
            if(obj == null)
               obj = new LazyInitializedSingleton(name);
            else
                Console.WriteLine("Object not created");
            return obj;
        }
    }
}
