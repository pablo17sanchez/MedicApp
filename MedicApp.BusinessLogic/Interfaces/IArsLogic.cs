using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
   public interface IArsLogic
    {
        ARS GetById(int id);
        IEnumerable<ARS> GetList();
        IEnumerable<ARSList> ARSPagedList(int page, int rows);
        int Insert(ARS ars);
        bool Update(ARS ars);
        bool Delete(ARS ars);
    }
}
