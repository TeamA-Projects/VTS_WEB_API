using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace VTS.DataAccess
{
    public class DBContext
    {
        public static string ConnectionString { get; set; }

        public string Query { get; set; }
        private static string GetConnectionString()
        {
            ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=admin;Database=VTS";
            return ConnectionString;
        }
      
        public async Task<DataSet> GetDataSet()
        {
            DataSet ds = new DataSet();
            try
            {
                var conn = new NpgsqlConnection(GetConnectionString());
                var cmd = new NpgsqlCommand(Query, conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                NpgsqlDataAdapter nda = new NpgsqlDataAdapter(cmd);
                nda.Fill(ds);
            }
            catch(Exception Ex)
            {

            }
            return await Task.FromResult(ds);
        }
    }
}
