using AluraFilmesAPI.Dtos;
using AluraFilmesAPI.Models;
using AutoMapper;

namespace AluraFilmesAPI.Profiles;


public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<CreateEnderecoDto, Endereco>();
        CreateMap<Endereco, ReadEnderecoDto>();
        CreateMap<UpdateEnderecoDto, Endereco>();
    }
}
