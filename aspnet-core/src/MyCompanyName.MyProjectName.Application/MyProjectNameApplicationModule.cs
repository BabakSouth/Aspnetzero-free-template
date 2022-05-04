using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyCompanyName.MyProjectName.Authorization;

namespace MyCompanyName.MyProjectName
{
    [DependsOn(
        typeof(MyProjectNameCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProjectNameApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyProjectNameAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyProjectNameApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}


