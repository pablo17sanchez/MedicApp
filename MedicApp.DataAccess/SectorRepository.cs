using Dapper;
using MedicApp.Models.Dtos;
using MedicApp.Models.Dtos.ListDtos;
using MedicApp.Repositories;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MedicApp.DataAccess
{
    public class SectorRepository : Repository<Sector>, ISectorRepository
    {
        public SectorRepository(string connectionString) : base(connectionString)
        {

        }
        public IEnumerable<SectorList> SectorPagedList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<SectorList>("dbo.SectorPagedList",
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
