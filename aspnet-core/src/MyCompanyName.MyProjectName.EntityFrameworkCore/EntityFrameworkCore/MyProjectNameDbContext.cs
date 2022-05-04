using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyCompanyName.MyProjectName.Authorization.Roles;
using MyCompanyName.MyProjectName.Authorization.Users;
using MyCompanyName.MyProjectName.MultiTenancy;

namespace MyCompanyName.MyProjectName.EntityFrameworkCore
{
    public class MyProjectNameDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectNameDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProjectNameDbContext(DbContextOptions<MyProjectNameDbContext> options)
            : base(options)
        {
        }
    }
}


