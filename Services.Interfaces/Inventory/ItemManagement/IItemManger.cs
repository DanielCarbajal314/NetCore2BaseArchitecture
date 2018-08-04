using Services.Interfaces.Common;
using Services.Interfaces.Inventory.ItemManagement.Requests;
using Services.Interfaces.Inventory.ItemManagement.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces.Inventory.ItemManagement
{
    public interface IItemManger : IGeneralManager<GeneralItem, NewItem, UpdateItem>
    {

    }
}
