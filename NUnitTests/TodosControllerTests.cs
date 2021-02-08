using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using mvcToDoList.Controllers;
using mvcToDoList.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.Entity;
using System.Net;

namespace NUnitTests
{
    class TodosControllerTests
    {

        [Test]
        public void IndexToDoItem()
        {
            //Arrange
            TodosController _todosController = new TodosController();

            //Act
            var result = _todosController.Index() as ViewResult;
            var myresult = (List<Todos>)result.Model;

            //Assert
            Assert.That(myresult.Count != 0);
            Assert.IsNotNull(result);
        }

        [Test]
        public void CreateToDoItem()
        {
            //Arrange
            TodosController _todosController = new TodosController();
            var model = new Todos() { DueDate = DateTime.Now, ID = 28, Name = "Toffee", Attributes = "Personal", Priority = "Urgent" };

            //Act
            var result = _todosController.Create(model);

            //Assert
            Assert.AreEqual(nameof(_todosController.Index), result.ViewName);
        }

        [Test]
        public void EditToDoItem()
        {
            //Arrange
            TodosController _todosController = new TodosController();
            var model = new Todos() { DueDate = DateTime.Now, ID = 17, Name = "Ram", Attributes = "Business", Priority = "Urgent" };

            //Act
            var result = _todosController.Edit(model);

            //Assert
            Assert.AreEqual(nameof(_todosController.Index), result.ViewName);
        }
        [Test]
        public void DetailsToDoItem()
        {
            //Arrange
            TodosController _todosController = new TodosController();

            //Act
            var result = _todosController.Details(2) as ViewResult;
            var myresult = (Todos)result.Model;

            //Assert
            Assert.IsTrue(myresult.ID == 2);
        }

        [Test]
        public void DeleteGetWithInvalidIdShouldReturnNotFound()
        {
            //Arrange
            TodosController _todosController = new TodosController();

            //Act
            var result = _todosController.Delete(0) as ViewResult;

            Assert.IsNull(result);
        }

        [Test]
        public void DeleteToDoItem()
        {
            //Arrange
            TodosController _todosController = new TodosController();

            //Act
            var result = _todosController.Delete(2) as ViewResult;
            var myresult = (Todos)result.Model;

            //Assert
            Assert.IsTrue(myresult.ID == 2);
        }

        //[Test]
        //public void DeleteConfirmedToDoItem()
        //{
        //    //Arrange
        //    TodosController _todosController = new TodosController();

        //    //Act
        //    var result = _todosController.DeleteConfirmed(22) as ViewResult;
        //    var myresult = (Todos)result.Model;

        //    //Assert
        //    Assert.IsTrue(myresult.ID == 22);
        //}
    }

}
