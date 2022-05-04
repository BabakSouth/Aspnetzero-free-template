using System.Threading.Tasks;
using Abp.Application.Services;
using MyCompanyName.MyProjectName.Sessions.Dto;

namespace MyCompanyName.MyProjectName.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}


