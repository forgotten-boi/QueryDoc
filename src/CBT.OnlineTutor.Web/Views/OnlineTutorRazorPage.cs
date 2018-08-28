using Abp.AspNetCore.Mvc.Views;

namespace CBT.OnlineTutor.Web.Views
{
    public abstract class OnlineTutorRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected OnlineTutorRazorPage()
        {
            LocalizationSourceName = OnlineTutorConsts.LocalizationSourceName;
        }
    }
}
