using AutoMapper;
using CBT.OnlineTutor.EClass;
using CBT.OnlineTutor.EClass.Dtos;

namespace CBT.OnlineTutor
{
    internal static class DtoMappings
    {
        public static void Map(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<Category, CategoryDto>().ForMember(t => t.ProgramListId, opts => opts.MapFrom(d => d.PList.Id));
            mapper.CreateMap<CBTContent, CBTContentDto>().ForMember(t => t.CategoryId, opts => opts.MapFrom(d => d.Categories.Id));
            mapper.CreateMap<ProgramList, ProgramListDto>().ForMember(t => t.ProgramTypeId, opts => opts.MapFrom(d => d.PType.Id));
        }
    }
}
