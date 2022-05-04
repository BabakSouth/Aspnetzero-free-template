using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MyCompanyName.MyProjectName.Web.Views
{
    public abstract class MyProjectNameRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MyProjectNameRazorPage()
        {
            LocalizationSourceName = MyProjectNameConsts.LocalizationSourceName;
        }
    }
}


