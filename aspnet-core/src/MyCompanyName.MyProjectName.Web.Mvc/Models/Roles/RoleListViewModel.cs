using System.Collections.Generic;
using MyCompanyName.MyProjectName.Roles.Dto;

namespace MyCompanyName.MyProjectName.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}


