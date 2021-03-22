using AutoMapper;
using GameStoreTFG.Data;
using GameStoreTFG.Model;

namespace GameStoreTFG.Config
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserModel ,Users>();
            CreateMap<GameModel, Games>();
        }
    }
}
