using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TestDataLibrary.DataAccess;

namespace TestDataLibrary
{
    /// <summary>
    /// Глобальная конфигурация подключений к источникам данных
    /// </summary>
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        /// <summary>
        /// Инициализация подключений
        /// </summary>
        public static void InitializeConnections()
        {
            // В данном случае реализована возможность подключения только к SQL базе данных
            SqlConnector sql = new SqlConnector();
            Connections.Add(sql);
        }

        /// <summary>
        /// Возвращает строку подключения по имени строки, сохраненной в параметрах приложения
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
