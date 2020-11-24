using System.Collections.Generic;

namespace Countries.Iterfaces
{
    public interface ILogic
    {
        Country GetCountryByName(string countryName, out string errorMessage);
        IList<Country> GetAllCountries(out string errorMessage);
        
        void SaveCountry(Country country, out string errorMessage);

        void CheckConnectToDatabase(out string errorMessage);
        void UpdateConfig(ConfigData data);
        ConfigData GetConfigData();
    }
}
