using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.Repositories
{
   public interface IServicioRepository : IRepository<Servicios>
    {
        IEnumerable<ServicioList> ServicioPagedList(int page, int rows);

    }
}
