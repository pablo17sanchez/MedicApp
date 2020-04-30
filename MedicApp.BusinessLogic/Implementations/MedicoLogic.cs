using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class MedicoLogic : IMedicoLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public MedicoLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Medico medico)
        {
            return _unitOfWork.Medico.Delete(medico);
        }

        public Medico GetById(int id)
        {
            return _unitOfWork.Medico.GetById(id);
        }

        public IEnumerable<Medico> GetList()
        {
            return _unitOfWork.Medico.GetList();
        }

        public int Insert(Medico medico)
        {
            return _unitOfWork.Medico.Insert(medico);

        }

        public IEnumerable<MedicoList> MedicoPagedList(int page, int rows)
        {
            return _unitOfWork.Medico.MedicoPagedList(page, rows);
        }

        public bool Update(Medico medico)
        {
            return _unitOfWork.Medico.Update(medico);
        }
    }
}
