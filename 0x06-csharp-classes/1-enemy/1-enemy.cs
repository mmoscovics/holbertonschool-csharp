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
    }
}
