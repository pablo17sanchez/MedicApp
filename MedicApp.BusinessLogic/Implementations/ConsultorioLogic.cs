using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System.Collections.Generic;
using MedicApp.Models.Dtos;

namespace MedicApp.BusinessLogic.Implementations
{
    public class ConsultorioLogic : IConsultorioLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConsultorioLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<ConsultorioList> ConsultorioPagedList(int page, int rows)
        {
            return _unitOfWork.Consultorio.ConsultorioPagedList(page, rows);
        }

        public bool Delete(Consultorio consultorio)
        {
            return _unitOfWork.Consultorio.Delete(consultorio);
        }

        public Models.Dtos.Consultorio GetById(int id)
        {
            return _unitOfWork.Consultorio.GetById(id);
        }

        public IEnumerable<Consultorio> GetList()
        {
            return _unitOfWork.Consultorio.GetList();
        }

        public int Insert(Consultorio consultorio)
        {
            return _unitOfWork.Consultorio.Insert(consultorio);
        }



        public bool Update(Consultorio consultorio)
        {
            return _unitOfWork.Consultorio.Update(consultorio);
        }
    }
}
