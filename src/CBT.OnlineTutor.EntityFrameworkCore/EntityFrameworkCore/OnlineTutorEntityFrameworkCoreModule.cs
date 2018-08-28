using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CBT.OnlineTutor.EntityFrameworkCore
{
    [DependsOn(
        typeof(OnlineTutorCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class OnlineTutorEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineTutorEntityFrameworkCoreModule).GetAssembly());
        }
    }
}