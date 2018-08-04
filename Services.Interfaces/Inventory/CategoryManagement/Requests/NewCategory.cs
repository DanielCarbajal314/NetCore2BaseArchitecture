using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.CategoryManagement.Requests
{
    public class NewCategory
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
