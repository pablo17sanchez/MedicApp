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
    public class ConsultorioRepository : Repository<Consultorio>, IConsultoriosRepository
    {
        public ConsultorioRepository(string connectionString) : base(connectionString)
        {

        }
        public IEnumerable<ConsultorioList> ConsultorioPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<ConsultorioList>("dbo.ConsultorioPagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
