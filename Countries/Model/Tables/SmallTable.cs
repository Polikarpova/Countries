using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Model
{
    abstract class SmallTable : Table
    {
        public override string TableName => throw new NotImplementedException();
        public string NameColumn => "name";

        public string GetInsertQuery(string name)
        {
            string query = String.Format("INSERT INTO {0} ({1}) VALUES ('{2}')", TableName, NameColumn, name);

            return query;
        }
    }
}
