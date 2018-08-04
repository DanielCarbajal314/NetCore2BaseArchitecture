using Services.Interfaces.Common;
using Services.Interfaces.Inventory.CategoryManagement.Requests;
using Services.Interfaces.Inventory.CategoryManagement.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.CategoryManagement
{
    public interface ICategoryManager: IGeneralManager<GeneralCategory,NewCategory,UpdateCategory>
    {
    }
}
