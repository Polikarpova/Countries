using System;
using System.IO;
using Newtonsoft.Json;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace Countries.Model.Connectors
{
    class MySQLConnector : Connector
    {
        public override DbConnection GetConnectionToDatabase()
        {
            string connectionString = GetConnecionString();

            return new MySqlConnection(connectionString);
        }

        public override DbCommand GetCommand(string query, DbConnection connection)
        {
            return new MySqlCommand(query, (MySqlConnection) connection);
        }

        public override DbParameter GetDoubleParameter(string parameterName, double value)
        {
            MySqlParameter parameter = new MySqlParameter(parameterName, MySqlDbType.Double);
            parameter.Value = value;

            return parameter;
        }
      
        protected override string GetConnecionString()
        {
            Console.WriteLine(String.Format("Configure database from {0}", configfilePath));

            ConfigData configData = GetConfigData();

            return "server=" + configData.Server + ";" +
                   "user=" + configData.User + ";" +
                   "database=" + configData.Database + ";" +
                   "password=" + configData.Password + ";";
        }
    }
}
