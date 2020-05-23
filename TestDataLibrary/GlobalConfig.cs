using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TestDataLibrary.DataAccess;

namespace TestDataLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitializeConnections()
        {
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
