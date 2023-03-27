using System;
using InventoryLibrary;
using System.Collections.Generic;
using System.Linq;

namespace InventoryLibrary
{
    public class BaseClass
    {
        public string id { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_updated { get; set; }

        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}
