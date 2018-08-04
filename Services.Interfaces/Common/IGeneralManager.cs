using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces.Common
{
    public interface IGeneralManager<GeneralDTO,NewDTO,UpdateDTO>
    {
        Task<List<GeneralDTO>> ListPage(Page page);
        Task<GeneralDTO> Create(NewDTO newRegistry);
        Task<GeneralDTO> Update(UpdateDTO updatedRegistry);
        Task Delete(int Id);
    }
}
