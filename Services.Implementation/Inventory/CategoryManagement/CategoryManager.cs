using Domain.Entities.Inventory;
using Infraestructure.Context.Inventory;
using Microsoft.EntityFrameworkCore;
using Services.Implementation.Inventory.CategoryManagement.Maps;
using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement;
using Services.Interfaces.Inventory.CategoryManagement.Requests;
using Services.Interfaces.Inventory.CategoryManagement.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Implementation.Inventory.CategoryManagement
{
    public class CategoryManager : ICategoryManager
    {
        public async Task<GeneralCategory> Create(NewCategory newRegistry)
        {
            using (InventoryDB db = new InventoryDB())
            {
                Category newCategory = newRegistry.toEntity();
                db.Categories.Add(newCategory);
                await db.SaveChangesAsync();
                return newCategory.toDTO();
            }
        }

        public async Task Delete(int Id)
        {
            using (InventoryDB db = new InventoryDB())
            {
                Category categoryToDelete = await db.Categories.FindAsync(Id);
                categoryToDelete.Deleted = true;
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<GeneralCategory>> ListPage(Page page)
        {
            using (InventoryDB db = new InventoryDB())
            {
                return await  db.Categories.Where(x => x.Deleted == false)
                                    .Skip(page.Order * page.Size)
                                    .Take(page.Size)
                                    .Select(x=>x.toDTO())
                                    .ToListAsync();
            }
        }

        public async Task<GeneralCategory> Update(UpdateCategory updatedRegistry)
        {
            using (InventoryDB db = new InventoryDB())
            {
                Category categoryToUpdate = await db.Categories.FindAsync(updatedRegistry.Id);
                updatedRegistry.Update(categoryToUpdate);
                await db.SaveChangesAsync();
                return categoryToUpdate.toDTO();
            }
        }
    }
}
