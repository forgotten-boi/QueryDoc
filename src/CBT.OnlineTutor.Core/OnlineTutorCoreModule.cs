using Abp.Modules;
using Abp.Reflection.Extensions;
using CBT.OnlineTutor.Localization;

namespace CBT.OnlineTutor
{
    public class OnlineTutorCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            OnlineTutorLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OnlineTutorCoreModule).GetAssembly());
        }
    }
}