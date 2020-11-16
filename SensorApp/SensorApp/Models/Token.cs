using System;
namespace SensorApp.Models
{
    public class Token
    {
        public int id { get; set; }
        public string access_token { get; set; }
        public string error_description { get; set; }
        public DateTime expiration_date { get; set; }
        public Token()
        { }
    }
}
