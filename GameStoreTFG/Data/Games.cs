using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GameStoreTFG.Data
{
    public class Games
    {
        [Key]
        public Guid id { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public double rate { get; set; }
        public string instroduction { get; set; }
        public string description { get; set; }
        public double maxPrice { get; set; }
        public double minPrice { get; set; }
        public double fixPrice{ get; set; }
        public DateTime createDate { get; set; }
        public DateTime publishDate { get; set; }
                
        public virtual IList<Categories> Categories { get; set; }
        public virtual IList<Comments> Comments { get; set; }
    }
}
