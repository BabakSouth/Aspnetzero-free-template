using System.Collections.Generic;
using MyCompanyName.MyProjectName.Roles.Dto;

namespace MyCompanyName.MyProjectName.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}


