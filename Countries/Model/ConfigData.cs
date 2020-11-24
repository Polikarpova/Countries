using System.IO;
using System.Security.Cryptography;

namespace Countries
{
    public class ConfigData
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }

        public ConfigData(string server, string user, string database, string password)
        {
            Server = server;
            User = user;
            Database = database;
            Password = password;
        }
    }
}
