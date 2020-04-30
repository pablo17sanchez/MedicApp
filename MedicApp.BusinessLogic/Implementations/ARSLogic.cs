using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class ARSLogic : IArsLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public ARSLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IEnumerable<ARSList> ConsultorioPagedList(int page, int rows)
        {
            return _unitOfWork.ARS.ArsPagedList(page, rows);
        }

        public bool Delete(ARS ars)
        {
            return _unitOfWork.ARS.Delete(ars);
        }

        public ARS GetById(int id)
        {
            return _unitOfWork.ARS.GetById(id);
        }

        public IEnumerable<ARS> GetList()
        {
            return _unitOfWork.ARS.GetList();
        }

        public int Insert(ARS ars)
        {
            return _unitOfWork.ARS.Insert(ars);
        }

        public bool Update(ARS ars)
        {
            return _unitOfWork.ARS.Update(ars);
        }
    }
}
