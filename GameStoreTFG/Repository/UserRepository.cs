using GameStoreTFG.Context;
using GameStoreTFG.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStoreTFG.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Users> GetUsers()
        {
            return _context.Users.ToList();
        }

        public Users GetUserInfo(Guid id)
        {
            return _context.Users.Find(id);
        }

        public Users AddUser(Users user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return user;
        }

        public Users UpdateUser(Users user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            
            return user;
        }

        public bool DropUser(Guid id)
        {
            bool result = false;
            Users u = _context.Users.Find(id);

            if (u != null)
            {
                _context.Users.Remove(u);
                _context.SaveChanges();
                result = true;
            }

            return result;
        }
    }
}
