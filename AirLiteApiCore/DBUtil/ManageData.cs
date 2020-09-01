using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirLiteApiCore.Model;
using Microsoft.Data.SqlClient;

namespace AirLiteApiCore.DBUtil
{
    public class ManageData : IManage<Data>
    {
        private const String GET_ALL = "select * from lpdv2k12_kbh_no2_gade";
        private const String GET_ONE = "select * from lpdv2k12_kbh_no2_gade WHERE gid = @gid";
        protected Data ReadNextElement(SqlDataReader reader)
        {
            Data data = new Data();

            data.Gid = reader.GetInt32(0);
            data.ObjectId = reader.GetInt32(1);
            data.Longitude = reader.GetDecimal(2);
            data.Latitude = reader.GetDecimal(3);
            data.XUtm = reader.GetInt64(4);
            data.YUtm = reader.GetInt64(5);
            data.XYUtm = reader.GetString(6);
            data.StreetNam = reader.GetString(7);
            data.HouseNum = reader.GetString(8);
            data.Kommune = reader.GetString(9);
            data.No2Street = reader.GetDecimal(10);
            data.Idnr = reader.GetInt64(11);

            return data;
        }
        public IEnumerable<Data> GetAll()
        {
            List<Data> liste = new List<Data>();

            SqlCommand cmd = new SqlCommand(GET_ALL, SQLConnectionSingleton.Instance.DbConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Data data = ReadNextElement(reader);
                liste.Add(data);
            }
            reader.Close();

            return liste;
        }
        public Data Get(int id)
        {
            Data data = null;

            SqlCommand cmd = new SqlCommand(GET_ONE, SQLConnectionSingleton.Instance.DbConnection);
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data = ReadNextElement(reader);
            }
            reader.Close();

            return data;
        }
    }
}
