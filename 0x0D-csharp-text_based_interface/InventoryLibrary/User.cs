using System;

namespace InventoryLibrary
{
    /// <summary>
    /// User class that inherit from BaseClass
    /// </summary>
    public class User : BaseClass
    {
        /// <summary>
        /// name of user created
        /// </summary>
        /// <value>name of user</value>
        public string name { get; set; }

        /// <summary>
        /// constructor to set the name
        /// </summary>
        /// <param name="name">name passed by user</param>
        public User(string name)
        {
            this.name = name;
        }
    }
}
