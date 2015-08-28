using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGL_Assistant
{
    // ReSharper disable once InconsistentNaming
    class SQLite
    {
        public SQLiteConnection NewSqLiteConnection(string dbLocation)
        {
            var connString = String.Format("Data Source={0};Version=3;", dbLocation);
            return new SQLiteConnection(connString);
        }
    }
}
