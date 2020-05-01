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
  public  class NCFRepository : Repository<NCF>, INCFRepository
    {

        public NCFRepository(string connectionString) : base(connectionString)
        {

        }

       

        public IEnumerable<NCFList> NCFPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<NCFList>("dbo.NCFPagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
