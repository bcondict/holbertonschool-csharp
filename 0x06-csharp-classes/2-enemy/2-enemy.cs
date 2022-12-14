using System;

namespace Enemies 
{
    /// <sumary>
    /// Define an enemy, Zombie with it's characteristics
    /// </sumary>

    public class Zombie
    {
        /// <sumary>health field of Zombie </sumary>  
        public int health;

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
    }
}
