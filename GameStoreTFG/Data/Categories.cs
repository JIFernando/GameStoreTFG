using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Data
{
    public class Categories
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }

        public virtual IList<Games> Games { get; set; }
    }
}
