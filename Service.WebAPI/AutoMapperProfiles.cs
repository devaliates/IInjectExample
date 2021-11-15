using AutoMapper;

using Data.Entities;

using Service.WebAPI.Kisiler;

namespace Service.WebAPI;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Kisi, KisiDto>().ReverseMap();
    }
}