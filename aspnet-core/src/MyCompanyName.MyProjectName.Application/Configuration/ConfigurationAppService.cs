using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyCompanyName.MyProjectName.Configuration.Dto;

namespace MyCompanyName.MyProjectName.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyProjectNameAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}


