using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSGL_Assistant.Properties;

namespace CSGL_Assistant
{
    // ReSharper disable once InconsistentNaming
    class SQLiteAssistant
    {
        public SQLiteConnection NewSqLiteConnection()
        {
            string dbLocation = Settings.Default.DBLocation;
            var connString = String.Format("Data Source={0};Version=3;", dbLocation);
            return new SQLiteConnection(connString);
        }
    }
}
