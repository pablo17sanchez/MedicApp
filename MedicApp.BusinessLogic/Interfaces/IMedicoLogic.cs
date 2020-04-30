using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
    public interface IMedicoLogic
    {
        Medico GetById(int id);
        IEnumerable<Medico> GetList();
        IEnumerable<MedicoList> MedicoPagedList(int page, int rows);
        int Insert(Medico medico);
        bool Update(Medico medico);
        bool Delete(Medico medico);
    }
}
