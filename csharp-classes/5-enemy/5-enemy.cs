using System;

namespace Enemies
{
    /// <summary>public class that defines a zombie.</summary>
    public class Zombie {
        /// <summary>public int that defines the health of a zombie.</summary>
        public int health;

        /// <summary>public zombie with health value 0.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>public zombie with health value as a variable.</summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>method that returns the value of health of the Zombie object.</summary>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>private field, default value "(No name)".</summary>
        private string name = "(No name)";

        /// <summary>public property, retrives and sets name.</summary>
        public string Name
        {
            get=> name;
            set=> name = value;
        }

        /// <summary>prints the Zombie object’s attributes to stdout.</summary>
        public override string ToString()
        {
            return "Zombie Name: " + name + " / Total Health: " + health;
        }
    }
}
