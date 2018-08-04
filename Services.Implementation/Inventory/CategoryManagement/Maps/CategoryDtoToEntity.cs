using Services.Interfaces.Inventory.CategoryManagement.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities.Inventory;

namespace Services.Implementation.Inventory.CategoryManagement.Maps
{
    static class CategoryDtoToEntity
    {
        public static Category toEntity(this NewCategory newCategory)
        {
            return new Category()
            {
                Name = newCategory.Name,
                Description = newCategory.Description
            };
        }

        public static Category Update(this UpdateCategory updateCategory, Category category)
        {
            category.Description = updateCategory.Description;
            return category;
        }
    }
}
