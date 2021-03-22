using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Data
{
    public class Users
    {
        [Key]
        public Guid id { get; set; }
        public string email { get; set; }
        public string loginName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int[] passwordHash { get; set; }
        public Guid rolId { get; set; }
    }
}
