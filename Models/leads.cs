using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TodoApi.Models {
     public partial class leads {
    //     public Leads () {
    //         Customers = new HashSet<Customers> ();
    //     }

        public long Id { get; set; }
        public string full_name { get; set; }
        public string company_name { get; set; }
         public string email { get; set; }
        public string phone { get; set; }
         public string project_name { get; set; }
         public string project_desc { get; set; }
        public string Department { get; set; }
        public string Message { get; set; }
        [JsonIgnore]
           public byte[] attached_file { get; set; }
           public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            // public string OriginalFileName { get; set; }
        // [JsonIgnore]
        // public ICollection<Customers> Customers { get; set; }
    }
}