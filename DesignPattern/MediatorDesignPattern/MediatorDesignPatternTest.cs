using System;

namespace DesignPattern.MediatorDesignPattern
{
    /// <summary>
    /// class for mediator design patter test
    /// </summary>
    public class MediatorDesignPatternTest
    {
        /// <summary>
        /// performs all the operation with respect to mediator design patter test 
        /// </summary>
        public void MediatorDesignPatternTestMethod()
        {
            //// create on mediator object
            IMediator mediator = new Mediator();

            ////create 5 users
            User user1 = new UserImpl(mediator, "sumit");
            User user2 = new UserImpl(mediator, "sandeep");
            User user3 = new UserImpl(mediator, "subham");
            User user4 = new UserImpl(mediator, "sanjeev");
            User user5 = new UserImpl(mediator, "suraj");

            ////add all the users
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            mediator.AddUser(user4);
            mediator.AddUser(user5);

            ////send message to all the users
            user1.Send("hi everyone");
            Console.WriteLine();
            user4.Send("i am  up");
        }
    }
}
