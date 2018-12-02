using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Letters.Controllers;
using Letters.Models;

namespace Letters.Tests
{
  [TestClass]
  public class WriterControllerTest
  {
    [TestMethod]
    public void New_ReturnsCorrectActionResult_True()
    {
      //Arrange
      WriterController controller = new WriterController();

      //Act
      ActionResult indexView = controller.New();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }

    [TestMethod]
    public void Create_ReturnsCorrectActionResult_True()
    {
      //Arrange
      WriterController controller = new WriterController();

      //Act
      ActionResult actionResult = controller.Create("location", "sender", "recipient");

      //Assert
      Assert.IsInstanceOfType(actionResult, typeof(RedirectToActionResult));
    }

    [TestMethod]
    public void Create_RedirectsToCorrectActionName_True()
    {
      //Arrange
      WriterController controller = new WriterController();
      RedirectToActionResult actionResult = controller.Create("location", "sender", "recipient") as RedirectToActionResult;

      //Act
      string actionName = actionResult.ActionName;

      //Assert
      Assert.AreEqual(actionName, "Show");
    }

    [TestMethod]
    public void Create_HasCorrectModelDatatype_Writer()
    {
      //Arrange
      ViewResult showView = new WriterController().Show() as ViewResult;

      //Act

      var modelDatatype = showView.ViewData.Model;

      //Assert
      Assert.IsInstanceOfType(modelDatatype, typeof(Writer));
    }

    [TestMethod]
    public void Show_ReturnsCorrectActionResult_True()
    {
      //Arrange
      WriterController controller = new WriterController();

      //Act
      ActionResult indexView = controller.New();

      //Assert
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));
    }
  }
}
