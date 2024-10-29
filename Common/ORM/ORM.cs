using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Common.ORM
{
    public class ORM : IORM
    {
        private IDBConfig _dbConfig;
        private int _timeOut = 60;

        public ORM( IDBConfig dbConfig )
        {
            this._dbConfig = dbConfig;
        }

        public List<T> ExecuteQuery<T>(string sql)
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_dbConfig.ConnectionString))
                {
                    var result = connection.Query<T>(sql, _timeOut).ToList();
                    return result;
                }
            } catch (Exception ex) {
                throw;
            }
        }

        public object ExecuteQuery(string sql, DynamicParameters dynamicParam)
        {
            throw new NotImplementedException();
        }

        public int ExecuteScalar<T>(string sqlPoc, DynamicParameters dynamicParam)
        {
            throw new NotImplementedException();
        }

        public List<T> GetListFromDBStoreProcedure<T>(string storeProcedure, DynamicParameters dynamicParam)
        {
            throw new NotImplementedException();
        }

        public List<T> GetListFromDBStoreProcedure<T>(string storeProcedure)
        {
            throw new NotImplementedException();
        }

        public List<object> GetListFromDBStoreProcedure(string storeProcedure, DynamicParameters dynamicParam)
        {
            throw new NotImplementedException();
        }

        public List<object> GetListFromDBStoreProcedure(string storeProcedure)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, dynamic> GetListFromDBStoreProcedureInStingDynamicDict(string Params, DynamicParameters dynamicParam)
        {
            throw new NotImplementedException();
        }
    }
}
