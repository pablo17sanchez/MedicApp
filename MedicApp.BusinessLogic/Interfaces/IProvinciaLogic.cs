using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
    public interface IProvinciaLogic
    {

        Provincia GetById(int id);
        IEnumerable<Provincia> GetList();
        IEnumerable<ProvinciaList> ProvinciaPagedList(int page, int rows);
        int Insert(Provincia provincia);
        bool Update(Provincia provincia);
        bool Delete(Provincia provincia);
    }
}
