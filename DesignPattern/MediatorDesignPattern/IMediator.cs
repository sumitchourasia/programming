using System;

namespace DesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// interface for medaitor
    /// </summary>
   public interface IMediator
    {
        /// <summary>
        /// Sends the message.
        /// </summary>
        public void SendMessage(string msg, User user);

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void AddUser(User user);
    }
}
