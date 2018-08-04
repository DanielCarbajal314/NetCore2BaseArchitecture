using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.ItemManagement.Requests
{
    public class NewItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
    }
}
