using System;
using System.Collections.Generic;

namespace DesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// Mediator class theat implements the IMediator interface
    /// </summary>
    /// <seealso cref="DesignPattern.MediatorDesignPattern.IMediator" />
    public class Mediator : IMediator
    {
        /// <summary>
        ///  users list
        /// </summary>
        List<User> usersList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mediator"/> class.
        /// </summary>
        public Mediator()
        {
           usersList = new List<User>();
        }

        public void AddUser(User user)
        {
            this.usersList.Add(user);
        }


        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        /// <param name="user">The user.</param>
        public void SendMessage(string msg , User user)
        {
            foreach(User eachuser in usersList)
            {
                if(eachuser != user)
                {
                    eachuser.Receive(msg);
                }
            }
        }
    }
}
