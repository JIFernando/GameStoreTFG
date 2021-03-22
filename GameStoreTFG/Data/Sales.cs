using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Data
{
    public class Sales
    {
        public Guid id { get; set; }
        public Guid gameId { get; set; }
        public Guid userId { get; set; }
        public double price { get; set; }
        public string gameKey { get; set; }
        public bool keyUse { get; set; }

        public virtual Games game { get; set; }
        public virtual Users user { get; set; }
    }
}
