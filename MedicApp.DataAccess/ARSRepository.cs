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
    public class ARSRepository : Repository<ARS>, IArsRepository
    {


        public ARSRepository(string connectionString) : base(connectionString)
        {

        }

        public IEnumerable<ARSList> ArsPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<ARSList>("dbo.ARSPagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
