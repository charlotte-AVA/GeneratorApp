using Microsoft.AspNetCore.Mvc;
using Songs.Controllers;
using Xunit;

namespace services.tests.serviceone
{
    public class serviceOneTests //make this public!
    {
        [Fact] // make this a test method
        public void GetTest()
        {
            SongsController songsController = new SongsController();
            var songsControllerResult = songsController.Get();

            Assert.NotNull(songsControllerResult);
            Assert.IsType<ActionResult<string>>(songsControllerResult);
        }
    }
}
