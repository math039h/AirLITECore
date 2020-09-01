using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AirLiteApiCore.DBUtil
{
    public class SQLConnectionSingleton
    {
        private static SQLConnectionSingleton _instance = new SQLConnectionSingleton();

        public static SQLConnectionSingleton Instance => _instance;

        private SQLConnectionSingleton()
        {
            _dbConnection = new SqlConnection(ConnString);
            _dbConnection.Open();
        }

        private SqlConnection _dbConnection;

        /*
         * Lokal database
        */
        protected const String ConnString =
            "jdbc:postgresql://http://rist8016.uni.au.dk::5555:5433/appdev_jk?user=AU685257&password=Qwerasdfzxcv46";        /*
         * Cloud Database
         */
        //private const String ConnString =
        //    @"Data Source=pele-easj-dbserver.database.windows.net;Initial Catalog=pele-easj-db;User ID=peleadm;Password=Secret1!;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SqlConnection DbConnection => _dbConnection;
    }
}
