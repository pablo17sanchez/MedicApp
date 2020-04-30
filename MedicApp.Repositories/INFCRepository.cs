using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;


namespace MedicApp.Repositories
{
    public interface INFCRepository : IRepository<NFC>
    {
        IEnumerable<NFCList> NCFPagedList(int page, int rows);

    }
}
