using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Interfaces
{
    public interface IServicioLogic
    {
        Servicios GetById(int id);
        IEnumerable<Servicios> GetList();
        IEnumerable<ServicioList> ServicioPagedList(int page, int rows);
        int Insert(Servicios servicio);
        bool Update(Servicios servicio);
        bool Delete(Servicios servicio);
    }
}
