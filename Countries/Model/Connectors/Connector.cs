using System;
using System.IO;
using Newtonsoft.Json;
using System.Data.Common;

namespace Countries.Model.Connectors
{
    abstract class Connector
    {
        protected readonly string configfilePath = "config.json";

        virtual public DbConnection GetConnectionToDatabase()
        {
            throw new NotImplementedException();
        }

        virtual public DbCommand GetCommand(string query, DbConnection connection)
        {
            throw new NotImplementedException();
        }

        virtual public DbParameter GetDoubleParameter(string parameterName, double value)
        {
            throw new NotImplementedException();
        }

        public ConfigData GetConfigData()
        {
            string pathToConfigFile = Path.Combine(Environment.CurrentDirectory, configfilePath);

            ConfigData data = GetDefaultConfigData();

            if (!File.Exists(pathToConfigFile))
            {
                GenerateConfigFile(pathToConfigFile, data);
            }
            else
            {
                data = JsonConvert.DeserializeObject<ConfigData>(File.ReadAllText(pathToConfigFile));
            }

            return data;
        }

        virtual protected ConfigData GetDefaultConfigData()
        {
            return new ConfigData("localhost", "root", "countries", "root");
        }

        public void UpdateConfig(ConfigData data)
        {
            string pathToConfigFile = Path.Combine(Environment.CurrentDirectory, configfilePath);

            if (!File.Exists(pathToConfigFile))
            {
                GenerateConfigFile(pathToConfigFile, data);
            }
            else
            {
                File.WriteAllText(pathToConfigFile, JsonConvert.SerializeObject(data));
            }
        }

        virtual protected string GetConnecionString()
        {
            throw new NotImplementedException();
        }

        protected void GenerateConfigFile(string filePath, ConfigData data)
        {
            File.Create(filePath).Close();

            File.WriteAllText(filePath, JsonConvert.SerializeObject(data));
        }
    }
}
