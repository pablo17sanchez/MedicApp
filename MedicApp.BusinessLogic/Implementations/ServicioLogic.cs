using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System;
using System.Collections.Generic;

namespace MedicApp.BusinessLogic.Implementations
{
    public class ServicioLogic : IServicioLogic
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServicioLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Servicios servicio)
        {
            return _unitOfWork.Servicio.Delete(servicio);
        }

        public Servicios GetById(int id)
        {
            return _unitOfWork.Servicio.GetById(id);
        }

        public IEnumerable<Servicios> GetList()
        {
            return _unitOfWork.Servicio.GetList();
        }

        public int Insert(Servicios servicio)
        {
            return _unitOfWork.Servicio.Insert(servicio);
        }

        public IEnumerable<ServicioList> ServicioPagedList(int page, int rows)
        {
            return _unitOfWork.Servicio.ServicioPagedList(page, rows);
        }

        public bool Update(Servicios servicio)
        {
            return _unitOfWork.Servicio.Update(servicio);
        }
    }
}
