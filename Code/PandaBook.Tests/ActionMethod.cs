using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using PandaBook.Controllers;

namespace PandaBook.Tests
{
    [TestClass]
    public class ActionMethod
    {
        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.About() as ViewResult;
            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void IndexWelcomeMessage()
        {
            // Arrange
            BookController controller = new BookController();

            // Act

            ViewResult result = controller.Index();
            // Assert
            Assert.AreEqual("Welcome to the shop. Kindly spend all your money!",
           controller.ViewBag.WelcomeMessage);
        }

    }
}
