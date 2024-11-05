using AutoMapper;

namespace Application.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Domain.Entities.Employee, Domain.JsonFiles.Employee>().ReverseMap();
    }
}