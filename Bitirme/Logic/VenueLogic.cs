﻿using Bitirme.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Bitirme.Logic
{
    public class VenueLogic
    {
        public async static Task<List<Venue>> GetVenues(double latitude, double longitude)
        {
            List<Venue> venues = new List<Venue>();

            var url = Venue.GenerateURL(latitude, longitude);

            using (HttpClient client = new HttpClient())
            {
                var response =  await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();
            }

           


            return venues;
        }
    }
}
