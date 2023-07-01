using ApiFilmes.Data.Dtos;
using ApiFilmes.Models;
using AutoMapper;

namespace ApiFilmes.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
    {
        CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<CreateCinemaDto, ReadCinemaDto>();
        CreateMap<UpdateCinemaDto, Cinema>();
    }
}
