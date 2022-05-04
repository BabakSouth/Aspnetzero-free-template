using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompanyName.MyProjectName.Configuration;

namespace MyCompanyName.MyProjectName.Web.Host.Startup
{
    [DependsOn(
       typeof(MyProjectNameWebCoreModule))]
    public class MyProjectNameWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyProjectNameWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectNameWebHostModule).GetAssembly());
        }
    }
}


