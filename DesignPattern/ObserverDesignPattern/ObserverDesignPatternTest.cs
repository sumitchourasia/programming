using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverDesignPattern
{
    public class ObserverDesignPatternTest
    {
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            ////creating the object for ConcreteSubject class.
            ConcreteSubject subject = new ConcreteSubject("sumit");

            ////Creating the object for ConcreteObserver class.
            ConcreteObserver observerOne = new ConcreteObserver(subject, "One");
            ConcreteObserver observerTwo = new ConcreteObserver(subject, "Two");
            subject.Attach(observerOne);
            subject.Attach(observerTwo);
            subject.Text = "changed now";
        }
    }
}
