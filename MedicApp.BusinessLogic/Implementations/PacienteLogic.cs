using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Implementations
{
    public class PacienteLogic : IPacienteLogic
    {

        private readonly IUnitOfWork _unitOfWork;
        public PacienteLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Paciente pacientek)
        {
            return _unitOfWork.Paciente.Delete(pacientek);
        }

        public Paciente GetById(int id)
        {
            return _unitOfWork.Paciente.GetById(id);
        }

        public IEnumerable<Paciente> GetList()
        {
            return _unitOfWork.Paciente.GetList();
        }

        public int Insert(Paciente paciente)
        {
            return _unitOfWork.Paciente.Insert(paciente);
        }

        public IEnumerable<PacienteList> PacientePagedList(int page, int rows)
        {
            return _unitOfWork.Paciente.PacientePagedList(page, rows);
        }

        public bool Update(Paciente paciente)
        {
            return _unitOfWork.Paciente.Update(paciente);
        }
    }
}
