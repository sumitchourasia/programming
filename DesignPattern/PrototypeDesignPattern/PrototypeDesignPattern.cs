using System;

namespace DesignPattern.PrototypeDesignPattern
{
    /// <summary>
    /// class for PrototypeDesignPattern
    /// </summary>
    public class PrototypeDesignPattern
    {
        /// <summary>
        /// PrototypedesignPatternmethod to execute all the operation
        /// </summary>
        public void PrototypeDesignPatternMethod()
        {
            ////new EMployee object creation 
            Employee empobj1 = new Employee();
            
            ////input the name
            Console.Write("enter employee name : ");
            empobj1.SetName(Console.ReadLine());
            ////input the age
            Console.Write("enter employee age : ");
            empobj1.SetAge(Convert.ToInt32(Console.ReadLine()));
            //// input the salary
            Console.Write("enter employee salary");
            empobj1.SetSalary(Convert.ToInt32(Console.ReadLine()));
            
            ////print the details
            Console.WriteLine(empobj1.GetDetails());

            ////clone the Employee object
            Employee empobj2 = empobj1.Clone();

            //// imput employee name
            Console.Write("enter employee name : ");
            empobj1.SetName(Console.ReadLine());

            //// input employee salary
            Console.Write("enter employee salary");
            empobj1.SetSalary(Convert.ToInt32(Console.ReadLine()));

            ////print the details
           Console.WriteLine( empobj1.GetDetails() );
           Console.WriteLine( empobj2.GetDetails() );
        }
    }
}
