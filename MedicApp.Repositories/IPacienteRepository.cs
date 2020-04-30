using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.Repositories
{
    public interface IPacienteRepository : IRepository<Paciente>
    {
        IEnumerable<PacienteList> PacientePagedList(int page, int rows);
    }
}
