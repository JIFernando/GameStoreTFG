using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Data
{
    public class MergeFields
    {
        [Key]
        public string key { get; set; }
        public string value { get; set; }
        public string language { get; set; }
    }
}
