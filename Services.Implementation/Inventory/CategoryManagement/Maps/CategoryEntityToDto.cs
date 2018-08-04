using Domain.Entities.Inventory;
using Services.Interfaces.Inventory.CategoryManagement.Requests;
using Services.Interfaces.Inventory.CategoryManagement.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementation.Inventory.CategoryManagement.Maps
{
    static class CategoryEntityToDto
    {
        public static GeneralCategory toDTO(this Category category)
        {
            return new GeneralCategory()
            {
                Name = category.Name,
                Description = category.Description,
                Id = category.Id,  
            };
        }
    }
}
