using System.Collections.Generic;
using MyCompanyName.MyProjectName.Roles.Dto;

namespace MyCompanyName.MyProjectName.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}

