using System.Numerics;

namespace AirLiteApiCore.Model
{
    public class Data
    {
        private int gid;
        private BigInteger object_id;
        private decimal longitude;
        private decimal latitude;
        private BigInteger x_utm;
        private BigInteger y_utm;
        private string x_y_utm;
        private string street_nam;
        private string house_num;
        private string kommune;
        private decimal no2_street;
        private BigInteger idnr;

        public int Gid
        {
            get => gid;
            set => gid = value;
        }

        public BigInteger ObjectId
        {
            get => object_id;
            set => object_id = value;
        }

        public decimal Longitude
        {
            get => longitude;
            set => longitude = value;
        }

        public decimal Latitude
        {
            get => latitude;
            set => latitude = value;
        }

        public BigInteger XUtm
        {
            get => x_utm;
            set => x_utm = value;
        }

        public BigInteger YUtm
        {
            get => y_utm;
            set => y_utm = value;
        }

        public string XYUtm
        {
            get => x_y_utm;
            set => x_y_utm = value;
        }

        public string StreetNam
        {
            get => street_nam;
            set => street_nam = value;
        }

        public string HouseNum
        {
            get => house_num;
            set => house_num = value;
        }

        public string Kommune
        {
            get => kommune;
            set => kommune = value;
        }

        public decimal No2Street
        {
            get => no2_street;
            set => no2_street = value;
        }

        public BigInteger Idnr
        {
            get => idnr;
            set => idnr = value;
        }



    }
}
