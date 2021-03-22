using GameStoreTFG.Model;
using System;
using System.Collections.Generic;

namespace GameStoreTFG.Services
{
    public interface IUserService
    {
        List<UserModel> GetUsers();
        UserModel GetUserInfo(Guid id);
        UserModel AddUser(UserModel user);
        UserModel UpdateUser(Guid id, UserModel user);
        bool DropUser(Guid id);
    }
}
