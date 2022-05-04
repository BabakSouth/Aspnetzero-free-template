using Abp.AspNetCore.Mvc.ViewComponents;

namespace MyCompanyName.MyProjectName.Web.Views
{
    public abstract class MyProjectNameViewComponent : AbpViewComponent
    {
        protected MyProjectNameViewComponent()
        {
            LocalizationSourceName = MyProjectNameConsts.LocalizationSourceName;
        }
    }
}


