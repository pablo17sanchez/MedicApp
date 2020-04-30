using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
  public  interface ISectorLogic
    {
        Sector GetById(int id);
        IEnumerable<Sector> GetList();
        IEnumerable<SectorList> SectorPagedList(int page, int rows);
        int Insert(Sector sector);
        bool Update(Sector sector);
        bool Delete(Sector sector);
    }
}
