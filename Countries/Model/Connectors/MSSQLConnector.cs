using System;
using Countries.Iterfaces;
using System.Data.Common;
using System.Data.SqlClient;

namespace Countries.Model.Connectors
{
    class MSSQLConnector : Connector
    {
        public override DbConnection GetConnectionToDatabase()
        {
            string connectionString = GetConnecionString();

            return new SqlConnection(connectionString);
        }

        public override DbCommand GetCommand(string query, DbConnection connection)
        {
            return new SqlCommand(query, (SqlConnection)connection);
        }

        public override DbParameter GetDoubleParameter(string parameterName, double value)
        {
            SqlParameter parameter = new SqlParameter(parameterName, System.Data.SqlDbType.Float);
            parameter.Value = value;

            return parameter;
        }

        protected override string GetConnecionString()
        {
            Console.WriteLine(String.Format("Configure database from {0}", configfilePath));

            ConfigData configData = GetConfigData();
            
            return "Data Source=" + configData.Server + ";" +
                   "Initial Catalog=" + configData.Database + ";" +
                   "Persist Security Info=" + "True" + ";" +
                   "User ID=" + configData.User + ";" +
                   "Password=" + configData.Password + ";";
        }

        protected override ConfigData GetDefaultConfigData()
        {
            return new ConfigData(@"localhost\SQLEXPRESS", "sa", "countries", "root");
        }
    }
}
