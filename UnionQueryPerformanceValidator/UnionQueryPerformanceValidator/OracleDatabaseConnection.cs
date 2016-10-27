using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace UnionQueryPerformanceValidator
{
    public class OracleDatabaseConnection
    {
        private OracleConnection _con;
        public void Connect()
        {
            _con = new OracleConnection();
            _con.ConnectionString = "Data Source=(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = pnli6066)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = pndev11204))); User Id=pi_sds_01; Password=pi_sds_01";
            _con.Open();
        }

        public void ExecuteQuery(string sql, QueryResultProcessor mResult)
        {
            OracleCommand command = _con.CreateCommand();
            
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mResult.AddToRowSet(new ResultRow(reader["PUID"].ToString()));
            }
        }
        
        public void Close()
        {
            _con.Close();
            _con.Dispose();
        }
    }
}
