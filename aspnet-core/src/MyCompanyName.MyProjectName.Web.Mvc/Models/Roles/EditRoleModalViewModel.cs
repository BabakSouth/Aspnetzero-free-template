using Abp.AutoMapper;
using MyCompanyName.MyProjectName.Roles.Dto;
using MyCompanyName.MyProjectName.Web.Models.Common;

namespace MyCompanyName.MyProjectName.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}


