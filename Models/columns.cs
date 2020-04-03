using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class columns
    {
         public columns () {
            elevators = new HashSet<elevators> ();
        }
        public long id { get; set; }
        public string column_type { get; set; }
        public int number_floors { get; set; }
        public string status { get; set; }
        public string info { get; set; }
        public string notes { get; set; }
        public long battery_id { get; set; }
        // public string building_type { get; set; }
        public batteries battery { get; set; }
        public ICollection<elevators> elevators { get; set; }
    }
}
