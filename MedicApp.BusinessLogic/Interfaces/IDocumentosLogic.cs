using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
    public interface IDocumentosLogic
    {
        Documentos GetById(int id);
        IEnumerable<Documentos> GetList();
        IEnumerable<Documentos> DocumentosPagedList(int page, int rows);
        int Insert(Documentos documentos);
        bool Update(Documentos documentos);
        bool Delete(Documentos documentos);
    }
}
