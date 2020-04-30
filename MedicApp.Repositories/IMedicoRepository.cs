using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Models.Dtos;
using System.Collections.Generic;


namespace MedicApp.Repositories
{

    public interface IMedicoRepository : IRepository<Medico>
    {

        //Abstracion de lo que tiene que tener nuestra clase heredada
        IEnumerable<MedicoList> MedicoPagedList(int page, int rows);

    }
}
