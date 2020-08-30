using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMap_Load_DataSet.Model
{
    public class ListOffices
    {

           public List<Office> Offices{ get; }
           public List<Office> Locations { get; }

        public ListOffices() 
        {
            Offices = new List<Office>();
        }

        public void Add_List_Map(string ubication, string phone, string email, string address, string town, string schedule, string departament,string postal_Code, string lat, string lon) 
        {
            Office c = new Office(ubication,phone,email,address,town,schedule,departament,postal_Code,lat,lon);
            Offices.Add(c);
        }
    }
}
