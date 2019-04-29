using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Controllers;
using ToDoList;

namespace ToDoList.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
          public void Index_ReturnsCorrectView_True()
          {
              //Arrange
              Home1 controller = new Home1();

              //Act
              ActionResult indexView = controller.Index();

              //Assert
              Assert.IsInstanceOfType(indexView, typeof(ViewResult));
          }

          [TestMethod]
          public void Index_HasCorrectModelType_ItemList()
          {
            //Arrange
            ViewResult indexView = new Home1().Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Item>));
          }
          
    }
}
