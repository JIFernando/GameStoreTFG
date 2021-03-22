using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameStoreTFG.Model
{
    public class UserModel
    {
        public Guid id { get; set; }
        public string email { get; set; }
        public string loginName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
    }
}
