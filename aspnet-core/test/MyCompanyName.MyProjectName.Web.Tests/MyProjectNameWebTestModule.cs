using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompanyName.MyProjectName.EntityFrameworkCore;
using MyCompanyName.MyProjectName.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyCompanyName.MyProjectName.Web.Tests
{
    [DependsOn(
        typeof(MyProjectNameWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyProjectNameWebTestModule : AbpModule
    {
        public MyProjectNameWebTestModule(MyProjectNameEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectNameWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyProjectNameWebMvcModule).Assembly);
        }
    }
}

