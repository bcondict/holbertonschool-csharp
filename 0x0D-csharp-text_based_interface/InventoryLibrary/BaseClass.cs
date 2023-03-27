using System;
using InventoryLibrary;
using System.Collections.Generic;
using System.Linq;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class the inherit all the classes
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// unique id for the class
        /// </summary>
        /// <value>different every run</value>
        public string id { get; set; }

        /// <summary>
        /// date when the class was created
        /// </summary>
        /// <value>value of moment when was created</value>
        public DateTime date_created { get; set; }

        /// <summary>
        /// date when the class was updated
        /// </summary>
        /// <value>vlaue of the moment that its value is modified</value>
        public DateTime date_updated { get; set; }

        /// <summary>
        /// base constructor to set the id, date_created and date_updated
        /// </summary>
        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}
