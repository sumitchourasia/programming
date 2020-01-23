using System;

namespace DesignPattern.ObserverDesignPattern
{
    public class ConcreteObserver : IObserver
    {
        /// <summary>
        /// The name
        /// </summary>
        public string name = "";
        /// <summary>
        /// The text
        /// </summary>
        public string text = "";
        /// <summary>
        /// The subject
        /// </summary>
        private Subject subject;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
        /// </summary>
        /// <param name="subject">The subject.</param>
        /// <param name="name">The name.</param>
        public ConcreteObserver(Subject subject, string name)
        {
            this.subject = subject;
            text = ((ConcreteSubject)subject).Text;
            this.name = name;
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            Console.WriteLine(name + " detected a change from: " + text + " to " + ((ConcreteSubject)subject).Text);

            text =((ConcreteSubject)subject).Text;
        }

    }
}
