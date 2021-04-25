using System;
using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ClassSchedule.Models;
using ClassSchedule.Controllers;
namespace ClassScheduleTests
{
    public class TeacherControllerTest
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            var initIrep = new Mock<IRepository<Teacher>>(); //Generate new a new mock instance
            var controllerCurrent = new TeacherController(initIrep.Object);
            var result = controllerCurrent.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}
