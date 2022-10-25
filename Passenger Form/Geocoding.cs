using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web;

namespace Passenger_Form
{
    class Geocoding
    {
        public static async Task<(string latitude, string longitude)> getCoordinates(string address)
        {
            string url = "https://py4e-data.dr-chuck.net/json?address=" + HttpUtility.UrlEncode(address) + "&key=42";
            var client = new HttpClient();
            var result = await client.GetStringAsync(url);
            dynamic json = JsonConvert.DeserializeObject(result);
            string latitude = json["results"][0]["geometry"]["location"]["lat"];
            string longitude = json["results"][0]["geometry"]["location"]["lng"];
            return (latitude: latitude, longitude: longitude);
        }
    }
}
