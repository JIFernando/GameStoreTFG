using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStoreTFG.Data
{
    public class Roles
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        
        public virtual IList<Users> Users { get; set; }
        public virtual IList<Permissions> Permissions { get; set; }
    }
}
