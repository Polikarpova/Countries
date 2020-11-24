using System;
using System.Collections.Generic;
using Countries.Iterfaces;

namespace Countries.Logic
{
    class LogicManager : ILogic
    {
        private IDatabase Database;

        public LogicManager(IDatabase db)
        {
            Database = db;
        }

        public Country GetCountryByName(string countryName, out string errorMessage)
        {
            errorMessage = "";
            Country country = new Country();

            try
            {
                country = Database.GetCountryByName(countryName);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }

            if (country.IsEmpty)
            {
                country = CountryAPI.GetCountryInfo(countryName);
            }

            return country;
        }

        public void SaveCountry(Country country, out string errorMessage)
        {
            errorMessage = "";

            try
            {
                Database.SaveCountry(country);
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        public IList<Country> GetAllCountries(out string errorMessage)
        {
            errorMessage = "";

            try
            {
                return Database.GetAllCountries();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
                return null;
            }
        }

        public void CheckConnectToDatabase(out string errorMessage)
        {
            errorMessage = "";
            try
            {
                Database.CheckConnectionToDatabase();
            }
            catch (Exception e)
            {
                errorMessage = e.Message;
            }
        }

        public void UpdateConfig(ConfigData data)
        {
            Database.UpdateConfig(data);
        }

        public ConfigData GetConfigData()
        {
            return Database.GetConfigData();
        }
    }
}
