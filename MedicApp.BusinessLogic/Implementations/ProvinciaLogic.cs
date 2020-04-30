using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class ProvinciaLogic : IProvinciaLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProvinciaLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Provincia provincia)
        {
            return _unitOfWork.Provincia.Delete(provincia);
        }

        public Provincia GetById(int id)
        {
            return _unitOfWork.Provincia.GetById(id);
        }

        public IEnumerable<Provincia> GetList()
        {
            return _unitOfWork.Provincia.GetList();
        }

        public int Insert(Provincia provincia)
        {
            return _unitOfWork.Provincia.Insert(provincia);
        }

        public IEnumerable<ProvinciaList> ProvinciaPagedList(int page, int rows)
        {
            return _unitOfWork.Provincia.ProvinciaPagedList(page, rows);
        }

        public bool Update(Provincia provincia)
        {
            return _unitOfWork.Provincia.Update(provincia);
        }
    }
}
