using AutoMapper;
using RKSoft.eShop.App.DTOs;
using RKSoft.eShop.Domain.Entities;

namespace RKSoft.eShop.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EStore, StoreDTO>().ReverseMap();
        }
    }
}