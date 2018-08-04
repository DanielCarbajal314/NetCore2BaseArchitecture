using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Inventory
{
    public class Item: NamedEntity
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
