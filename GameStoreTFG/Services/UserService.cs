using AutoMapper;
using GameStoreTFG.Data;
using GameStoreTFG.Model;
using GameStoreTFG.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GameStoreTFG.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public List<UserModel> GetUsers()
        {
            List<Users> list = _userRepository.GetUsers();

            return _mapper.Map<Users[], UserModel[]>(list.ToArray()).ToList();
        }

        public UserModel GetUserInfo(Guid id)
        {
            Users u = _userRepository.GetUserInfo(id);

            return _mapper.Map<Users, UserModel>(u);
        }

        public UserModel AddUser(UserModel user)
        {
            Users u = _userRepository.AddUser(_mapper.Map<UserModel, Users>(user));

            return _mapper.Map<Users, UserModel>(u);
        }

        public UserModel UpdateUser(Guid id, UserModel user)
        {
            Users u = _userRepository.UpdateUser(_mapper.Map<UserModel, Users>(user));

            return _mapper.Map<Users, UserModel>(u);
        }

        public bool DropUser(Guid id)
        {
            return _userRepository.DropUser(id);
        }
    }
}
