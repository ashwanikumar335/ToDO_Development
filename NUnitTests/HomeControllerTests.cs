using System;
using NUnit.Framework;
using System.Web.Mvc;
using mvcToDoList.Controllers;

namespace NUnitTests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [TestCase]
        public void IndexActionReturnsIndexView()
        {
            //Arrange
            string expected = "Index";
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index() as ViewResult;

            //Assert
            Assert.AreEqual(expected, result.ViewName);
        }
        [TestCase]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
        [TestCase]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
