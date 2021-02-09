using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Persistência.Infrastructure.Database
{
    public class SqlConnectionDatabase : IRelationalDatabase
    {
        public SqlConnectionDatabase()
        {
            this.connectionString = "";
        }

        private string connectionString;

        public void Save<T>(T obj)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                var queryString = GenericMap.Builder(obj);

                SqlCommand command = new SqlCommand(queryString, connection);
                var parameters = GenericMap.BuilderParameters(obj);

                foreach(var parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }

                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public List<T> All<T>()
        {
            throw new Exception("Falta fazer");
        }

        public void Remove<T>(T obj)
        {
            throw new Exception("Falta fazer");
        }
    }
}
