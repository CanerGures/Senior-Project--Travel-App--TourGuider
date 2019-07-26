using Bitirme.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bitirme.Models
{
    public class Venue
    {
        public static string GenerateURL(double latitude, double longitude)
        {
           return  string.Format(Constants.VENUE_SEARCH, latitude,longitude, Constants.CLIENT_ID, Constants.CLIENT_SECRET, DateTime.Now.ToString("yyyyMMdd"));
        }
    }
}
