using AutoMapper;
using QuadEFModels.Entities;
using QuadModels;

namespace QuadModelEntityExtensions.Extensions
{
    public static class ModelsMap
    {
        static ModelsMap()
        {
            Mapper.CreateMap<ActiveQuad, ActiveQuadEntity>()
                .ForMember(x => x.ActiveQuadEntityId, opts => opts.MapFrom(src => src.Id));

            Mapper.AssertConfigurationIsValid();
        }

        public static ActiveQuadEntity ToEntity(this ActiveQuad activeQuad)
        {
            return activeQuad == null
                ? null
                : Mapper.Map<ActiveQuad, ActiveQuadEntity>(activeQuad);
        }
    }
}
