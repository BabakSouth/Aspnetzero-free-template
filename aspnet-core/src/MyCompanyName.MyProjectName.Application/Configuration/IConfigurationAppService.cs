using System.Threading.Tasks;
using MyCompanyName.MyProjectName.Configuration.Dto;

namespace MyCompanyName.MyProjectName.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}


