using System;

namespace DesignPattern.PrototypeDesignPattern
{
    /// <summary>
    /// class Employee extends IEmployee Interface
    /// </summary>
    /// <seealso cref="DesignPattern.PrototypeDesignPattern.IEmployee" />
    public class Employee : IEmployee
    {
        private string name;
        private int age;
        private int salary;

        /// <summary>
        /// Override the ToString() method
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
           return  string.Format("Name = {0}, Age = {1}, Salary {2}", name, age, salary);
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.name;
        }
        /// <summary>
        /// Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the age.
        /// </summary>
        /// <returns></returns>
        public int GetAge()
        {
            return this.age;
        }

        /// <summary>
        /// Sets the age.
        /// </summary>
        /// <param name="age">The age.</param>
        public void SetAge(int age)
        {
            this.age = age;
        }
        /// <summary>
        /// Gets the salary.
        /// </summary>
        /// <returns></returns>
        public int GetSalary()
        {
            return this.salary;
        }
        /// <summary>
        /// Sets the salary.
        /// </summary>
        /// <param name="salary">The salary.</param>
        public void SetSalary(int salary)
        {
            this.salary = salary;
        }
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns></returns>
        public override string GetDetails()
        {
            return this.ToString();
        }
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
    }
}
