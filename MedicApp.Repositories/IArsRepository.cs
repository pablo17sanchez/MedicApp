using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.Repositories
{
    public interface IArsRepository : IRepository<ARS>
    {
        IEnumerable<ARSList> ArsPagedList(int page, int rows);

    }
}
