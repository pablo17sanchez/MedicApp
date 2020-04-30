using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Models.Dtos;
using System.Collections.Generic;

namespace MedicApp.Repositories
{
   public interface ISectorRepository : IRepository<Sector>
    {
        IEnumerable<SectorList> SectorPagedList(int page, int rows);

    }
}
