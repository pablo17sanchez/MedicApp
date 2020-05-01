using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;
using MedicApp.Models.Dtos;

namespace MedicApp.Repositories
{
   public  interface IDocumentosRepository : IRepository<Documentos>
    {
        IEnumerable<DocumentosList> DocumentosPagedList(int page, int rows);
    }
}
