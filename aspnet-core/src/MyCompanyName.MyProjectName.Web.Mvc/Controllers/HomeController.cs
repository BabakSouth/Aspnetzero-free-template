using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyCompanyName.MyProjectName.Controllers;

namespace MyCompanyName.MyProjectName.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyProjectNameControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}


