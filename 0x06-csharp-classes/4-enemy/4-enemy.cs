using System;

namespace Enemies
{
    /// <summary>Base class of a Zombie enemy</summary>
    public class Zombie
    {
        /// <summary>Field for Zombie health</summary>
        private int health;
        /// Field for Zombie name
        private string name = "(No name)";

        /// Property getter and setter for name
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

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

        /// <summary>Method to get Zombie health</summary>
        /// <return>Value of health</return>
        public int GetHealth()
        {
            return this.health;
        }
    }
}
