using AdvertApi.Models;
using AutoMapper;

namespace AdvertAPI.Services.Profiles
{
    public class AdvertProfile : Profile
    {
        public AdvertProfile()
        {
            CreateMap<AdvertModel, AdvertDBModel>();
        }
    }
}
