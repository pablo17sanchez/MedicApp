using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Interfaces
{
    public interface IPacienteLogic
    {
        Paciente GetById(int id);
        IEnumerable<Paciente> GetList();
        IEnumerable<PacienteList> PacientePagedList(int page, int rows);
        int Insert(Paciente paciente);
        bool Update(Paciente paciente);
        bool Delete(Paciente pacientek);
    }
}
