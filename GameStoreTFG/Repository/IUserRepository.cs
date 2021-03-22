using GameStoreTFG.Data;
using System;
using System.Collections.Generic;

namespace GameStoreTFG.Repository
{
    public interface IUserRepository
    {
        List<Users> GetUsers();
        Users GetUserInfo(Guid id);
        Users AddUser(Users user);
        Users UpdateUser(Users user);
        bool DropUser(Guid id);
    }
}
