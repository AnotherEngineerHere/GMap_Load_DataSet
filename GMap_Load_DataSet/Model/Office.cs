using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap_Load_DataSet.Model
{
    public class Office
    {


        public string Ubication { get; }
        public string Phone { get; }
        public string Email { get; }
        public string Address { get; }
        public string Town { get; }
        public string Schedule { get; }
        public string Departament { get; }
        public string Postal_Code { get; }
        public string lat { get; }
        public string lon { get; }

        public Office(string ubication, string phone, string email, string address, string town, string schedule, string departament,string postal_Code, string lat, string lon)
        {
            Ubication = ubication;
            Phone = phone;
            Email = email;
            Address = address;
            Town = town;
            Schedule = schedule;
            Departament = departament;
            Postal_Code = postal_Code;
            this.lat = lat;
            this.lon = lon;
        }
        public Office(string location, string t, string lo, string la)
        {
             Ubication = location;
            Town = t;
            lon = lo;
            lat = la;

        }

    }
}
