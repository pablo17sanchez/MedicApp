using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Interfaces
{
    public interface IUsuarioLogic
    {
        Usuarios GetById(int id);
        IEnumerable<Usuarios> GetList();
        IEnumerable<UsuariosList> UsuarioPagedList(int page, int rows);
        Usuarios ValidateUser(string usuario, string password);

        int Insert(Usuarios usuario);
        bool Update(Usuarios usuario);
        bool Delete(Usuarios usuario);
    }
}
