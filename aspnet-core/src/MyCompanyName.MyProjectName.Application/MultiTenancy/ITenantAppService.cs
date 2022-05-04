using Abp.Application.Services;
using MyCompanyName.MyProjectName.MultiTenancy.Dto;

namespace MyCompanyName.MyProjectName.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}



