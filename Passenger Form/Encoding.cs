using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passenger_Form
{
    class Encoding
    {
        public static string encode(string text)
        {
            byte[] plain = System.Text.Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plain);
        }

        public static string decode(string text)
        {
            byte[] plain = Convert.FromBase64String(text);
            return System.Text.Encoding.UTF8.GetString(plain);
        }
    }
}
