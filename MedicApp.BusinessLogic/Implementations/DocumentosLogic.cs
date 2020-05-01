using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Implementations
{
    public class DocumentosLogic : IDocumentosLogic
    {

        private readonly IUnitOfWork _unitOfWork;
        public DocumentosLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Documentos documentos)
        {
            return _unitOfWork.Documentos.Delete(documentos);
        }

        public IEnumerable<Documentos> DocumentosPagedList(int page, int rows)
        {
            return _unitOfWork.Documentos.DocumentosPagedList(page, rows);
        }

        public Documentos GetById(int id)
        {
            return _unitOfWork.Documentos.GetById(id);
        }

        public IEnumerable<Documentos> GetList()
        {
            return _unitOfWork.Documentos.GetList();
        }

        public int Insert(Documentos documentos)
        {
            return _unitOfWork.Documentos.Insert(documentos);
        }

        public bool Update(Documentos documentos)
        {
            return _unitOfWork.Documentos.Update(documentos);
        }
    }
}
