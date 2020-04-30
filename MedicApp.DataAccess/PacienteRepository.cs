using Dapper;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MedicApp.DataAccess
{
    public class PacienteRepository  : Repository<Paciente>, IPacienteRepository
    {

        public PacienteRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<PacienteList> PacientePagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<PacienteList>("dbo.PacientePagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
