using Merge;
using Merge.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace services.tests.servicethree
{
    public class serviceThreeTest
    {
        private AppSettings appSettings = new AppSettings()
        {
            songsServiceURL = "https://cemtest1.azurewebsites.net", //replace with /SONGS URL
            singersServiceURL = "https://cemtest2.azurewebsites.net" // replace with /SINGERS URL
        };

        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);
        }

    }
}