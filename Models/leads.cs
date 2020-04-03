using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TodoApi.Models {
     public partial class leads {

        public long Id { get; set; }
        
        public string Full_name { get; set; }
        public string Company_name { get; set; }
         public string Email { get; set; }
        public string Phone { get; set; }
         public string project_name { get; set; }
        //  public string project_desc { get; set; }
        public string Department { get; set; }
        public string Message { get; set; }
        [JsonIgnore]
           public byte[] Attached_file { get; set; }
           public DateTime Created_at { get; set; }
            public DateTime Updated_at { get; set; }
            
            // public string OriginalFileName { get; set; }
       
    }
}