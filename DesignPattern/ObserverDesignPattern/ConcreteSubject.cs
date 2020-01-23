using System;
using System.Collections.Generic;

namespace DesignPattern.ObserverDesignPattern
{
    public class ConcreteSubject : Subject
    {
        /// <summary>
        /// The text
        /// </summary>
        private string text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteSubject"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        public ConcreteSubject(string text)
        {
            this.text = text;
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
                ////calling of notify method.
                Notify();
            }
        }

    }
}
