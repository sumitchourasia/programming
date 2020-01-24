using System;

namespace DesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// UserImpl class that extends the abstract class user
    /// </summary>
    /// <seealso cref="DesignPattern.MediatorDesignPattern.User" />
    public class UserImpl : User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserImpl"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        /// <param name="name">The name.</param>
        public UserImpl(IMediator mediator,string name) : base(mediator,name)
        {
           
        }

        /// <summary>
        /// Sends the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Send(string msg)
        {
            Console.WriteLine("{0} sending message : {1}",this.Name,msg);
            mediator.SendMessage(msg,this);
        }

        /// <summary>
        /// Receives the specified MSG.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public override void Receive(string msg)
        {
            Console.WriteLine("{0} received : {1}",this.Name,msg);
        }
    }
}
