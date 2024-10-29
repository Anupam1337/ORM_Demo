using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Common.ORM
{
    public interface IORM
    {
        List<T> GetListFromDBStoreProcedure<T>(string storeProcedure, DynamicParameters dynamicParam );
        List<T> GetListFromDBStoreProcedure<T>(string storeProcedure);
        List<Object> GetListFromDBStoreProcedure (string storeProcedure, DynamicParameters dynamicParam);
        List<Object> GetListFromDBStoreProcedure (string storeProcedure);
        List<T> ExecuteQuery<T>(string sql);
        object ExecuteQuery(string sql, DynamicParameters dynamicParam);
        int ExecuteScalar<T>(string sqlPoc, DynamicParameters dynamicParam);
        Dictionary<string, dynamic> GetListFromDBStoreProcedureInStingDynamicDict(string Params, DynamicParameters dynamicParam);
    }
}
