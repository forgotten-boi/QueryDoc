using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CBT.OnlineTutor
{
    [DependsOn(
        typeof(OnlineTutorCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OnlineTutorApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineTutorApplicationModule).GetAssembly());

            //We must declare mappings to be able to use AutoMapper
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                DtoMappings.Map(mapper);
            });
        }
    }
}