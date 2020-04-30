using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
   public interface IConsultorioLogic
    {
        Consultorio GetById(int id);
        IEnumerable<Consultorio> GetList();
        IEnumerable<ConsultorioList> ConsultorioPagedList(int page, int rows);
        int Insert(Consultorio consultorio);
        bool Update(Consultorio consultorio);
        bool Delete(Consultorio consultorio);
    }
}
