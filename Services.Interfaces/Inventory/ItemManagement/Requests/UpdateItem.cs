using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.ItemManagement.Requests
{
    public class UpdateItem
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
