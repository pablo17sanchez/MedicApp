using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Implementations
{
    public class CitasLogic : ICitasLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public CitasLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<CitasList> CitasPagedList(int page, int rows)
        {
            return _unitOfWork.Citas.CitasPagedList(page, rows);
        }

        public bool Delete(Citas cita)
        {
            return _unitOfWork.Citas.Delete(cita);
        }

        public Citas GetById(int id)
        {
            return _unitOfWork.Citas.GetById(id);
        }

        public IEnumerable<Citas> GetList()
        {
            return _unitOfWork.Citas.GetList();
        }

        public int Insert(Citas cita)
        {
            return _unitOfWork.Citas.Insert(cita);
        }

        public bool Update(Citas cita)
        {
            return _unitOfWork.Citas.Update(cita);
        }
    }
}
