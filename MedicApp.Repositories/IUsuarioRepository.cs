using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System.Collections.Generic;

namespace MedicApp.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuarios>
    {
        Usuarios ValidateUser(string usuario, string password);

        IEnumerable<UsuariosList> UsuariosPagedList(int page, int rows);

    }
}
