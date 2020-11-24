using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries.Model
{
    abstract class Table
    {
        public abstract string TableName { get; }

        public string IdColumn => "id";

        public string GetAllSelectByStringValueQuery(string whereColumn, string whereValue)
        {
            string query = String.Format("SELECT * FROM {0} WHERE {1}='{2}'", TableName, whereColumn, whereValue);

            return query;
        }
    }
}
