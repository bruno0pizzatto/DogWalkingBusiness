using AutoMapper;
using DogWalkingBusiness.Applications.DTOs;
using DogWalkingBusiness.Domain.Entities;

namespace DogWalkingBusiness.Applications.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Client
            CreateMap<Client, ClientDTO>().ReverseMap();

            // Dog
            CreateMap<Dog, DogDTO>().ReverseMap();

            // Walk
            CreateMap<Walk, WalkDTO>().ReverseMap();
        }
    }
}
