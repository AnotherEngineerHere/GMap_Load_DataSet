﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap_Load_DataSet.Model
{
    public class ListOffices
    {

        List<Office> Offices;
        List<Office> Locations;

        public ListOffices() 
        {
            Offices = new List<Office>();
            Locations = new List<Office>();
        }

        public void Add_List_Map(string ubication, string phone, string email, string address, string town, string schedule, string departament, string country, string postal_Code, string lat, string lon) 
        {
            Office c = new Office(ubication,phone,email,address,town,schedule,departament,country,postal_Code,lat,lon);
            Office d = new Office(ubication, town, lon, lat);
            Offices.Add(c);
            Locations.Add(d);
        }
    }
}
