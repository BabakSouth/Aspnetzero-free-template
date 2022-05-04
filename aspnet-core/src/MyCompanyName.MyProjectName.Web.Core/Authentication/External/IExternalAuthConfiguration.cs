using System.Collections.Generic;

namespace MyCompanyName.MyProjectName.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}


