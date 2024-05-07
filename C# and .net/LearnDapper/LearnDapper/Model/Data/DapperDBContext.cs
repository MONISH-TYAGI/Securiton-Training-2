using Microsoft.Data.SqlClient;
using System.Data;

namespace LearnDapper.Model.Data
{
    public class DapperDBContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString; // Changed variable name to follow convention
        public DapperDBContext(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._connectionString = this._configuration.GetConnectionString("connection");

        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
