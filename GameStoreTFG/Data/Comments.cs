using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Data
{
    public class Comments
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public Guid gameId { get; set; }
        public Guid userId { get; set; }
        public double description { get; set; }
        public int likes { get; set; }
        public int disLikes { get; set; }
        public double rating { get; set; }
        
        public virtual Games Game { get; set; }
        public virtual Users User{ get; set; }
    }
}
