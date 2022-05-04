using System.Threading.Tasks;
using MyCompanyName.MyProjectName.Models.TokenAuth;
using MyCompanyName.MyProjectName.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyCompanyName.MyProjectName.Web.Tests.Controllers
{
    public class HomeController_Tests: MyProjectNameWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}

