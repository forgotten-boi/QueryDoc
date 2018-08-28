using System.Reflection;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CBT.OnlineTutor.Web.Startup;

namespace CBT.OnlineTutor.Web.Tests
{
    [DependsOn(
        typeof(OnlineTutorWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class OnlineTutorWebTestModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineTutorWebTestModule).GetAssembly());
        }
    }
}