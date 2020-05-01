using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class NCFLogic : INCFLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public NCFLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(NCF nfc)
        {
            return _unitOfWork.NCF.Delete(nfc);
        }

        public NCF GetById(int id)
        {
            return _unitOfWork.NCF.GetById(id);
        }

        public IEnumerable<NCF> GetList()
        {
            return _unitOfWork.NCF.GetList();
        }

        public int Insert(NCF ncf)
        {
            return _unitOfWork.NCF.Insert(ncf);
        }

        public IEnumerable<NCFList> NCFPagedList(int page, int rows)
        {
            return _unitOfWork.NCF.NCFPagedList(page, rows);
        }

        public bool Update(NCF ncf)
        {
            return _unitOfWork.NCF.Update(ncf);
        }
    }
}
