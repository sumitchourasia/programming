using System;

namespace DesignPattern.MediatorDesignPattern
{
    public abstract class User
    {
        protected string name;
        protected IMediator mediator;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get => this.name; set => this.name = value; }
        /// <summary>
        /// Gets or sets the mediator.
        /// </summary>
        /// <value>
        /// The mediator.
        /// </value>
        public string Mediator { get => this.name; set => this.name = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="name">The name.</param>
        public User(IMediator mediator,string name)
        {
            this.mediator = mediator;
            this.name = name;
        }
        /// <summary>
        /// Sends the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Send(string msg);
        /// <summary>
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public abstract void Receive(string msg);
    }
}
