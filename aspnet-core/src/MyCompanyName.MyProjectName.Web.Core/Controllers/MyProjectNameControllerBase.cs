using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyCompanyName.MyProjectName.Controllers
{
    public abstract class MyProjectNameControllerBase: AbpController
    {
        protected MyProjectNameControllerBase()
        {
            LocalizationSourceName = MyProjectNameConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}


