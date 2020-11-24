using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Countries.Iterfaces;
using Countries.Model.Connectors;

namespace Countries.Model
{
    class Database : IDatabase
    {
        private Connector Connector;

        private readonly CityTable CityTable = new CityTable();
        private readonly RegionTable RegionTable = new RegionTable();
        private readonly CountryTable CountryTable = new CountryTable();

        public Database(Connector connector, out string errorMessage)
        {
            errorMessage = "";

            Connector = connector;

            try
            {
                CheckConnectionToDatabase();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        public void CheckConnectionToDatabase()
        {
            DbConnection connection = Connector.GetConnectionToDatabase();
            OpenConnection(connection);
            DbCommand command = Connector.GetCommand(CountryTable.GetCheckQuery(), connection);
            var result = command.ExecuteNonQuery();

            CloseConnection(connection);
        }

        public Country GetCountryByName(string countryName)
        {
            Country country = new Country();

            DbConnection connection = Connector.GetConnectionToDatabase();
            OpenConnection(connection);

            DbCommand command = Connector.GetCommand(
                CountryTable.GetCountryInfoQuery(countryName, CityTable.TableName, RegionTable.TableName),
                connection);
            DbDataReader dataReader = command.ExecuteReader();

            if (dataReader.HasRows && dataReader.Read())
            {
                country.Name = dataReader[CountryTable.NameColumn].ToString();
                country.Code = dataReader[CountryTable.CodeColumn].ToString();
                country.Capital = dataReader[CountryTable.CapitalColumn].ToString();
                country.Area = (float)Convert.ToDouble(dataReader[CountryTable.AreaColumn]);
                country.Population = (int)dataReader[CountryTable.PopulationColumn];
                country.Region = dataReader[CountryTable.RegionColumn].ToString();
            }

            CloseConnection(connection);

            return country;
        }

        public bool SaveCountry(Country country)
        {
            bool isOk = false;

            int capitalId = GetIdFromTabelByName(CityTable, country.Capital);
            int regionId = GetIdFromTabelByName(RegionTable, country.Region);
            int countryId = GetIdByStringValue(CountryTable, CountryTable.CodeColumn, country.Code);

            if (countryId == -1)
            {
                isOk = InsertCountry(country, capitalId, regionId);
            }
            else
            {
                isOk = UpdateCountry(country, countryId, capitalId, regionId);
            }

            return isOk;
        }
        
        public IList<Country> GetAllCountries()
        {
            IList<Country> countries = new List<Country>();

            DbConnection connection = Connector.GetConnectionToDatabase();
            OpenConnection(connection);

            DbCommand command = Connector.GetCommand(
                CountryTable.GetCountriesInfoQuery(CityTable.TableName, RegionTable.TableName), 
                connection);
            DbDataReader dataReader = command.ExecuteReader();

            while (dataReader.HasRows && dataReader.Read())
            {
                Country country = new Country
                {
                    Name = dataReader[CountryTable.NameColumn].ToString(),
                    Code = dataReader[CountryTable.CodeColumn].ToString(),
                    Capital = dataReader[CountryTable.CapitalColumn].ToString(),
                    Area = (float)Convert.ToDouble(dataReader[CountryTable.AreaColumn]),
                    Population = (int)dataReader[CountryTable.PopulationColumn],
                    Region = dataReader[CountryTable.RegionColumn].ToString()
                };

                countries.Add(country);
            }

            CloseConnection(connection);

            return countries;
        }

        public void UpdateConfig(ConfigData data)
        {
            Connector.UpdateConfig(data);
        }

        public ConfigData GetConfigData()
        {
            return Connector.GetConfigData();
        }

        private bool OpenConnection(DbConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                Console.WriteLine("Openning connection to database..."); //+ вывод данных из конфига

                connection.Open();

                Console.WriteLine("Connection succsessful!");

                return true;
            }

            return false;
        }

        private void CloseConnection(DbConnection connection)
        {
            connection.Close();
        }

        private int GetIdFromTabelByName(SmallTable table, string name)
        {
            int id = GetIdByStringValue(table, "name", name);

            if (id == -1)
            {
                DbConnection connection = Connector.GetConnectionToDatabase();
                OpenConnection(connection);

                DbCommand command = Connector.GetCommand(
                    table.GetInsertQuery(name), connection);
                command.ExecuteNonQuery();

                CloseConnection(connection);

                id = GetIdFromTabelByName(table, name);
            }

            return id;
        }

        private int GetIdByStringValue(Table table, string column, string value)
        {
            DbConnection connection = Connector.GetConnectionToDatabase();
            OpenConnection(connection);

            DbCommand command = Connector.GetCommand(table.GetAllSelectByStringValueQuery(column, value), connection);
            var result = command.ExecuteScalar();

            CloseConnection(connection);

            int id = -1;

            if (result != null)
            {
                id = (int)result;
            }

            return id;
        }
        
        private bool InsertCountry(Country country, int capitalId, int regionId)
        {
            DbConnection connection = Connector.GetConnectionToDatabase();
            OpenConnection(connection);

            DbCommand command = Connector.GetCommand(
                CountryTable.GetInsertQuery(country, capitalId, regionId), 
                connection);
            int rows = command.ExecuteNonQuery();

            CloseConnection(connection);

            return rows > 0;
        }

        private bool UpdateCountry(Country country, int countryId, int capitalId, int regionId)
        {
            DbConnection connection = Connector.GetConnectionToDatabase();
            OpenConnection(connection);

            DbCommand command = Connector.GetCommand(
                CountryTable.GetUpdateQuery(country, countryId, capitalId, regionId),
                connection);
            DbParameter areaParameter = Connector.GetDoubleParameter("@" + CountryTable.AreaColumn, country.Area);
            command.Parameters.Add(areaParameter);

            int rows = command.ExecuteNonQuery();

            CloseConnection(connection);

            return rows > 0;
        }
    }
}
