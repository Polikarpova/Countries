using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Countries.Logic
{
    class CountryAPI
    {
        static public Country GetCountryInfo(string countryName)
        {
            Country country = new Country();

            WebRequest request = WebRequest.Create("https://restcountries.eu/rest/v2/name/" + countryName);

            try
            {
                WebResponse response = request.GetResponse();

                using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                {
                    string json = stream.ReadLine();

                    //Полученные данные приходят в видет массива - вытаскиваем из ответа его первый элемент
                    JObject data = JArray.Parse(json)[0].ToObject<JObject>();

                    country = data.ToObject<Country>();                    
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }

            return country;
        }
    }
}
