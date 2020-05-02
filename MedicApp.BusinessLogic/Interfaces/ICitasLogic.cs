using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Interfaces
{
    public  interface ICitasLogic
    {

        Citas GetById(int id);
        IEnumerable<Citas> GetList();
        IEnumerable<CitasList> CitasPagedList(int page, int rows);
        int Insert(Citas cita);
        bool Update(Citas cita);
        bool Delete(Citas cita);
    }
}
