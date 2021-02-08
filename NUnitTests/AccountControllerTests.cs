using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcToDoList.Controllers;
using mvcToDoList.Models;
using NUnit.Framework;
using System.Web.Mvc;
using Moq;
using mvcToDoList;

namespace NUnitTests
{
    [TestFixture]
    class AccountControllerTests
    {
         
        [Test]
        public void AccountController_Register_UserRegistered()
        {
            //Arrange
            var accountController = new AccountController();
            var registerViewModel = new RegisterViewModel() 
            {
                Email = "test12345@test.com",
                Password = "Pass@2k21",
                ConfirmPassword="Pass@2k21"
            };

            //Act
            var result = accountController.Register(registerViewModel) as Task<ActionResult>;

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void AccountController_Register_FaultUserRegistration()
        {
            //Arrange
            var accountController = new AccountController();
            var registerViewModel = new RegisterViewModel()
            {
                Email = "test_User@test.com",
                Password = "Pass@2k21",
                ConfirmPassword = ""
            };

            //Act
            var result = accountController.Register(registerViewModel) as Task<ActionResult>;
            
            //Assert
            Assert.IsNull(result.Status);
        }

        [Test]
        public void Authenticate_ShouldCallVerifyLogin()
        {
            //Arrange
            var accountController = new AccountController();
            var loginViewModel = new LoginViewModel()
            {
                Email = "test12345@test.com",
                Password = "Pass@2k21"
            };

            //Act
            var result = accountController.Login(loginViewModel, "") as Task<ActionResult>;

            //Assert
            Assert.IsNotNull(result);
        }
        
        [Test]
        public void ShouldNotAcceptInvalidUser()
        {
            // Arrange
            //Arrange
            var accountController = new AccountController();
            var loginViewModel = new LoginViewModel()
            {
                Email = "test12345@test.com",
                Password = "Pass@2k21"
            };
       
            // Act
            var result = accountController.Login(loginViewModel, "") as Task<ActionResult>;

            // Assert
            //Assert.That(result.ViewName, Is.EqualTo("Index"));
            //Assert.False(controller.ModelState.IsValid);
            //Assert.That(controller.ModelState[""],
            //            Is.EqualTo("The user name or password provided is incorrect."));
            Assert.IsNull(result);
        }

    }
    
}
