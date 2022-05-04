using Abp.AutoMapper;
using MyCompanyName.MyProjectName.Sessions.Dto;

namespace MyCompanyName.MyProjectName.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}


