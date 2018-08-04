using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.CategoryManagement.Requests
{
    public class UpdateCategory
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
