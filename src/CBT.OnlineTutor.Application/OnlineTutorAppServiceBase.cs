using Abp.Application.Services;

namespace CBT.OnlineTutor
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class OnlineTutorAppServiceBase : ApplicationService
    {
        protected OnlineTutorAppServiceBase()
        {
            LocalizationSourceName = OnlineTutorConsts.LocalizationSourceName;
        }
    }
}