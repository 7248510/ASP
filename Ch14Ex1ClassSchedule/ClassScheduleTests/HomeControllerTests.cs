using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ClassSchedule.Models;
using ClassSchedule.Controllers;
namespace ClassScheduleTests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var newUnit = new Mock<IClassScheduleUnitOfWork>(); //Generate the new unit
            var schoolClasses = new Mock<IRepository<Class>>(); //Test the classes
            var days = new Mock<IRepository<Day>>();
            newUnit.Setup(r => r.Classes).Returns(schoolClasses.Object);
            newUnit.Setup(r => r.Days).Returns(days.Object);
            var http = new Mock<IHttpContextAccessor>(); //Testing HTTP's Context
            var controller = new HomeController(newUnit.Object, http.Object); //Test the controller
            var result = controller.Index(0); //Setting to the current index(0)
            Assert.IsType<ViewResult>(result); //Get the result
        }
    }
}