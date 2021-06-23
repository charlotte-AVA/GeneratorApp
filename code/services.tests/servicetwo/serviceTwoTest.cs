using Microsoft.AspNetCore.Mvc;
using Singers.Controllers;
using Xunit;

namespace services.tests.servicetwo
{
    public class serviceTwoTests //make this public!
    {
        [Fact] // make this a test method
        public void GetTest()
        {
            SingersController singersController = new SingersController();
            var singersControllerResult = singersController.Get();

            Assert.NotNull(singersControllerResult);
            Assert.IsType<ActionResult<string>>(singersControllerResult);
        }
    }
}