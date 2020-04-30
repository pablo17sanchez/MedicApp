using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class SectorLogic : ISectorLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public SectorLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Sector sector)
        {
            return _unitOfWork.Sector.Delete(sector);
        }

        public Sector GetById(int id)
        {
            return _unitOfWork.Sector.GetById(id);
        }

        public IEnumerable<Sector> GetList()
        {
            return _unitOfWork.Sector.GetList();
        }

        public int Insert(Sector sector)
        {
            return _unitOfWork.Sector.Insert(sector);
        }

        public IEnumerable<SectorList> SectorPagedList(int page, int rows)
        {
            return _unitOfWork.Sector.SectorPagedList(page, rows);
        }

        public bool Update(Sector sector)
        {
            return _unitOfWork.Sector.Update(sector);
        }
    }
}
