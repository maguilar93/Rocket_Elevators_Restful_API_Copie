using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TodoApi.Models
{
    public class buildings
    {
        public buildings () {
            batteries = new HashSet<batteries> ();
            building_details = new HashSet<building_details> ();
        }
        public long id { get; set; }
        public string admin_full_name { get; set; }
        
        public string admin_email { get; set; }
        public string admin_phone { get; set; }
        public string tech_full_name { get; set; }
        public string tech_email { get; set; }
        public string tech_phone { get; set; }
        // public int customer_id { get; set; }
        // public int address_id { get; set; }
        // public addresses address { get; set; }
        // public customers customer { get; set; }
        [JsonIgnore]
        public ICollection<batteries> batteries { get; set; }
        public ICollection<building_details> building_details { get; set; }
    }
}
