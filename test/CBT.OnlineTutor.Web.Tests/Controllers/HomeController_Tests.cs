using System.Threading.Tasks;
using CBT.OnlineTutor.Web.Controllers;
using Shouldly;
using Xunit;

namespace CBT.OnlineTutor.Web.Tests.Controllers
{
    public class HomeController_Tests: OnlineTutorWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
