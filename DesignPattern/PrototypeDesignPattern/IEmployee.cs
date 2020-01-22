using System;

namespace DesignPattern.PrototypeDesignPattern
{
    public abstract class IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        public abstract Employee Clone();

        /// <summary>
        /// Gets the details.
        /// </summary>
        public abstract string GetDetails();

    }
}
