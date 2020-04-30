using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class NFCLogic : INCFLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public NFCLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(NFC nfc)
        {
            return _unitOfWork.NFC.Delete(nfc);
        }

        public NFC GetById(int id)
        {
            return _unitOfWork.NFC.GetById(id);
        }

        public IEnumerable<NFC> GetList()
        {
            return _unitOfWork.NFC.GetList();
        }

        public int Insert(NFC nfc)
        {
            return _unitOfWork.NFC.Insert(nfc);
        }

        public IEnumerable<NFCList> NCFPagedList(int page, int rows)
        {
            return _unitOfWork.NFC.NCFPagedList(page, rows);
        }

        public bool Update(NFC nfc)
        {
            return _unitOfWork.NFC.Update(nfc);
        }
    }
}
