using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
   public interface INCFLogic
    {

        NCF GetById(int id);
        IEnumerable<NCF> GetList();
        IEnumerable<NCFList> NCFPagedList(int page, int rows);
        int Insert(NCF ncf);
        bool Update(NCF ncf);
        bool Delete(NCF ncf);
    }
}
