using Dapper;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace MedicApp.DataAccess
{
    public class UsuarioRepository : Repository<Usuarios>, IUsuarioRepository
    {
        public UsuarioRepository(string connectionString) : base(connectionString)
        {

        }
        public IEnumerable<UsuariosList> UsuariosPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<UsuariosList>("dbo.UsuariosPagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public Usuarios ValidateUser(string usuario, string password)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@usuario", usuario);
            parameters.Add("@password", password);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<Usuarios>(
                    "dbo.ValidateUser", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
