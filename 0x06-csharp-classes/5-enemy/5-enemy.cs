using System;

namespace Enemies 
{
    /// <sumary>
    /// Define an enemy, Zombie with it's characteristics
    /// </sumary>

    public class Zombie
    {
        /// <sumary>health field of Zombie </sumary>  
        private int health;
        private string name = "(No name)";

        /// <sumary>Constructor to <see cref="Zombie"/> class.</sumary> 
        public Zombie()
        {
            health = 0;
        }

        /// <sumary>Constructor to <see cref="Zombie"/> class that sets heat to a value.</sumary> 
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
                return;
            }
            throw new ArgumentException("Health must be greater than or equal to 0");
        }

        /// <sumary> Constuctor with get and set property to <see cref="Zombie"/> class.</sumary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <sumary>Get health of <see cref="Zombie"/>.</sumary>
        /// <returns>Health of <see cref="Zombie"/>.</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <sumary> format to print in stdou <see cref="Zombie"/> object.</sumary>
        public override string ToString() => $"Zombie Name: {name} / Total Health: {health}";
    }
}
