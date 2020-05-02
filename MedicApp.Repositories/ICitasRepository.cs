using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.Repositories
{
    public interface ICitasRepository : IRepository<Citas>
    {
        IEnumerable<CitasList> CitasPagedList(int page, int rows);

    }
}
