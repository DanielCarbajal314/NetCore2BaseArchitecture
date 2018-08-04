using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement;
using Services.Interfaces.Inventory.CategoryManagement.Requests;
using Services.Interfaces.Inventory.CategoryManagement.Responses;

namespace Presentation.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private ICategoryManager _categoryManager;

        public CategoryController(ICategoryManager categoryManager)
        {
            this._categoryManager = categoryManager;
        }

        [HttpPost("Create")]
        public async Task<GeneralCategory> Create([FromBody] NewCategory newRegistry)
        {
            return await this._categoryManager.Create(newRegistry);
        }

        [HttpDelete("Delete")]
        public async Task Delete(int Id)
        {
            await this._categoryManager.Delete(Id);
        }

        [HttpGet("List")]
        public async Task<List<GeneralCategory>> ListPage(Page page)
        {
            return await this._categoryManager.ListPage(page);
        }

        [HttpPatch("Update")]
        public async Task<GeneralCategory> Update([FromBody] UpdateCategory updatedRegistry)
        {
            return await this._categoryManager.Update(updatedRegistry);
        }
    }
}