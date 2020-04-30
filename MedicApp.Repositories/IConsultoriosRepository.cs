using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Models.Dtos;
using System.Collections.Generic;



namespace MedicApp.Repositories
{
    public interface IConsultoriosRepository : IRepository<Consultorio>
    {
        IEnumerable<ConsultorioList> ConsultorioPagedList(int page, int rows);

    }
}
