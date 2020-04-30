using Dapper;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MedicApp.DataAccess
{
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {

        public MedicoRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<MedicoList> MedicoPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<MedicoList>("dbo.MedicoPagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
