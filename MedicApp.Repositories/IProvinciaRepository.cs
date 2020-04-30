using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.Repositories
{
    public interface IProvinciaRepository : IRepository<Provincia>
    {
        IEnumerable<ProvinciaList> ProvinciaPagedList(int page, int rows);

    }
}
