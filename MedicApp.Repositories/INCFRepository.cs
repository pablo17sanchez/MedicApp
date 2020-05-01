using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;


namespace MedicApp.Repositories
{
    public interface INCFRepository : IRepository<NCF>
    {
        IEnumerable<NCFList> NCFPagedList(int page, int rows);

    }
}
