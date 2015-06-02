using AutoMapper;
using QuadEFModels.Entities;
using QuadModels;

namespace QuadModelEntityExtensions.Extensions
{
    public static class EntitiesMap
    {
        static EntitiesMap()
        {
            Mapper.CreateMap<ActiveQuadEntity, ActiveQuad>()
                .ConstructUsing(x => new ActiveQuad(x.ActiveQuadEntityId));

            Mapper.AssertConfigurationIsValid();
        }

        public static ActiveQuad ToModel(this ActiveQuadEntity activeQuad)
        {
            return activeQuad == null
                ? null
                : Mapper.Map<ActiveQuadEntity, ActiveQuad>(activeQuad);
        }
    }
}
