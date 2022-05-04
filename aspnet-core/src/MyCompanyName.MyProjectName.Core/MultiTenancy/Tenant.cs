using Abp.MultiTenancy;
using MyCompanyName.MyProjectName.Authorization.Users;

namespace MyCompanyName.MyProjectName.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}


