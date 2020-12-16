using System;

namespace Enemies
{
    /// <summary>Base class of a Zombie enemy</summary>
    public class Zombie
    {
        /// <summary>Field for Zombie health</summary>
        public int health;

        /// <summary>Constructor for Class <see cref="Zombie"/></summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>Constructor for Class <see cref="Zombie"/> with argument</summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                this.health = value;
        }
    }
}
