using System;

namespace DesignPattern.ObserverDesignPattern
{
    /// <summary>
    /// interface with update method
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update();
    }
}
