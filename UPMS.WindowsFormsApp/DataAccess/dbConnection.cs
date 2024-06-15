using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UPMS.WindowsFormsApp.DataAccess
{
    public static class dbConnection
    {
        public static string dbCon(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
