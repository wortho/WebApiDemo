using System.Web.Mvc;
using WebApiDemo.Controllers;
using Xunit;
using Assert = Xunit.Assert;

namespace WebApiDemo.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Home Page", result.ViewBag.Title);
        }
    }
}
