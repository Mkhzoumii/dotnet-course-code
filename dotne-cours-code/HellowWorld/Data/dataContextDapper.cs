using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HellowWorld.Data
{
     public class dataContextDapper
     {
          private string? _conictionString;

          // private IConfiguration _config;
          public dataContextDapper(IConfiguration config)
          {
               // _config=config;
               _conictionString = config.GetConnectionString("defaultConnection");

          }
          public IEnumerable<T> loadData<T>(string sql)
          {
               IDbConnection dbConnection = new SqlConnection(_conictionString);
               return dbConnection.Query<T>(sql);
          }
          public T loadDataSingle<T>(string sql)
          {
               IDbConnection dbConnection = new SqlConnection(_conictionString);
               return dbConnection.QuerySingle<T>(sql);
          }
          public bool executSql(string sql)
          {
               IDbConnection dbConnection = new SqlConnection(_conictionString);
               return (dbConnection.Execute(sql) > 0);
          }
          public int executSqlRowCount(string sql)
          {
               IDbConnection dbConnection = new SqlConnection(_conictionString);
               return dbConnection.Execute(sql);
          }
     }


}