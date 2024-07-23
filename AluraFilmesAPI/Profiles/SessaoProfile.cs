using AluraFilmesAPI.Dtos;
using AluraFilmesAPI.Models;
using AutoMapper;

namespace AluraFilmesAPI.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile() 
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}
