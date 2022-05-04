using Abp.Authorization;
using MyCompanyName.MyProjectName.Authorization.Roles;
using MyCompanyName.MyProjectName.Authorization.Users;

namespace MyCompanyName.MyProjectName.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}


