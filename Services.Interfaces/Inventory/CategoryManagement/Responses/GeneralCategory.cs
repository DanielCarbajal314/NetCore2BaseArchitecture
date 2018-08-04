using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.CategoryManagement.Responses
{
    public class GeneralCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
