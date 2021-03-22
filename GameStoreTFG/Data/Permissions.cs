using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStoreTFG.Data
{
    
    public class Permissions
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string code { get; set; }

        public virtual IList<Roles> Roles { get; set; }
    }
}
