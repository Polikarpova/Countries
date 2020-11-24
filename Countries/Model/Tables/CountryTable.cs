using System;

namespace Countries.Model
{
    class CountryTable: Table
    {
        public override string TableName => "country";

        public string NameColumn => "name";
        public string CodeColumn => "code";
        public string CapitalColumn => "capital_id";
        public string AreaColumn => "area";
        public string PopulationColumn => "population";
        public string RegionColumn => "region_id";

        public string GetCountryInfoQuery(string countryName, string cityTableName, string regionTableName)
        {
            string query = GetCountriesInfoQuery(cityTableName, regionTableName) +
                           String.Format(" WHERE {0}.{1}='{2}'", TableName, NameColumn, countryName);

            return query;
        }

        public string GetCountriesInfoQuery(string cityTableName, string regionTableName)
        {
            string query = String.Format("SELECT {0}.{3}, " +
                                                "{0}.{4}, " +
                        
                        "{1}.{3} as {7}, " +
                                                "{0}.{5}, " +
                                                "{0}.{6}, " +
                                                "{2}.{3} as {8} " +
                                         "FROM (({0} " +
                                                "INNER JOIN {1} ON {0}.{7}={1}.{9}) " +
                                                "INNER JOIN {2} ON {0}.{8}={2}.{9})", TableName,
                                                                                      cityTableName,
                                                                                      regionTableName,
                                                                                      NameColumn,
                                                                                      CodeColumn,
                                                                                      AreaColumn,
                                                                                      PopulationColumn,
                                                                                      CapitalColumn,
                                                                                      RegionColumn,
                                                                                      IdColumn);

            return query;
        }

        public string GetInsertQuery(Country country, int capitalId, int regionId)
        {
            string area = country.Area.ToString().Replace(',', '.');

            string query = String.Format("INSERT INTO {0} ({1}, {2}, {3}, {4}, {5}, {6}) " +
                                         "VALUES ('{7}', '{8}', {9}, '{10}', {11}, {12})", TableName, NameColumn, 
                                                                                           CodeColumn, CapitalColumn, 
                                                                                           AreaColumn, PopulationColumn,
                                                                                           RegionColumn, country.Name,
                                                                                           country.Code, capitalId, 
                                                                                           area, country.Population,
                                                                                           regionId);
                       
            return query;
        }

        public string GetUpdateQuery(Country country, int countryId, int capitalId, int regionId)
        {
            string area = country.Area.ToString().Replace(',', '.');

            string query = String.Format("UPDATE {0} SET {1}='{2}', {3}='{4}', {5}={6}, " +
                                                        "{7}=@{7}, {8}={9}, {10}={11} " +
                                         "WHERE {12}={13}", TableName, NameColumn, country.Name,
                                                            CodeColumn, country.Code, CapitalColumn,
                                                            capitalId, AreaColumn,
                                                            PopulationColumn, country.Population, RegionColumn,
                                                            regionId, IdColumn, countryId);

            return query;
        }

        public string GetCheckQuery()
        {
            return String.Format("SELECT * FROM {0}", TableName);
        }
    }
}
