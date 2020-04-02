using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class buildings
    {
        public Buildings () {
            batteries = new HashSet<batteries> ();
            buildingDetails = new HashSet<building_Details> ();
        }
        public long id { get; set; }
        public string admin_full_name { get; set; }
        public string admin_email { get; set; }
        public string admin_phone { get; set; }
        public string tech_full_name { get; set; }
        public string tech_email { get; set; }
        public string tech_phone { get; set; }
        public int customer_id { get; set; }
        public int address_id { get; set; }
        public Addresses address { get; set; }
        public Customers customer { get; set; }
        [JsonIgnore]
        public ICollection<batteries> batteries { get; set; }
        public ICollection<building_details> building_Details { get; set; }
    }
}
