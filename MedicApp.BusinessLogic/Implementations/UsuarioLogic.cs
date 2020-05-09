using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicApp.BusinessLogic.Implementations
{
    public class UsuarioLogic : IUsuarioLogic
    {

        private readonly IUnitOfWork _unitOfWork;
        public UsuarioLogic(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool Delete(Usuarios usuario)
        {
            return _unitOfWork.Usuario.Delete(usuario);
        }

        public Usuarios GetById(int id)
        {
            return _unitOfWork.Usuario.GetById(id);
        }

        public IEnumerable<Usuarios> GetList()
        {
            return _unitOfWork.Usuario.GetList();
        }

        public int Insert(Usuarios usuario)
        {
            return _unitOfWork.Usuario.Insert(usuario);
        }

        public bool Update(Usuarios usuario)
        {
            return _unitOfWork.Usuario.Update(usuario);
        }

        public IEnumerable<UsuariosList> UsuarioPagedList(int page, int rows)
        {
            return _unitOfWork.Usuario.UsuariosPagedList(page, rows);
        }

        public Usuarios ValidateUser(string usuario, string password)
        {
            return _unitOfWork.Usuario.ValidateUser(usuario, password);
        }
    }
}
