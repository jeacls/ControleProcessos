using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WS_DicasRapidas.Models
{
    public static class Functions
    {
        public static string Base64Encode(string sTexto)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(sTexto);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string sBase64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(sBase64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}