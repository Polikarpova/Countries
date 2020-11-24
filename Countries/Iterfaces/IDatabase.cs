using System.Collections.Generic;

namespace Countries.Iterfaces
{
    public interface IDatabase
    {
        Country GetCountryByName(string countryName);
        IList<Country> GetAllCountries();
        
        bool SaveCountry(Country country);

        void CheckConnectionToDatabase();
        void UpdateConfig(ConfigData data);
        ConfigData GetConfigData();
    }
}
