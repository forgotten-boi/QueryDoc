using Abp.AspNetCore.Mvc.Controllers;

namespace CBT.OnlineTutor.Web.Controllers
{
    public abstract class OnlineTutorControllerBase: AbpController
    {
        protected OnlineTutorControllerBase()
        {
            LocalizationSourceName = OnlineTutorConsts.LocalizationSourceName;
        }
    }
}