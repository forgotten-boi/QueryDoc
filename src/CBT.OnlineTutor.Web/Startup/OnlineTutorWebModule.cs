using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CBT.OnlineTutor.Configuration;
using CBT.OnlineTutor.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CBT.OnlineTutor.Web.Startup
{
    [DependsOn(
        typeof(OnlineTutorApplicationModule), 
        typeof(OnlineTutorEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class OnlineTutorWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public OnlineTutorWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(OnlineTutorConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<OnlineTutorNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(OnlineTutorApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineTutorWebModule).GetAssembly());
        }
    }
}