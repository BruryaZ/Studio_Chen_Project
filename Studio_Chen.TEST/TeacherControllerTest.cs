using Microsoft.AspNetCore.Mvc;
using Studio_Chen.API.Controllers;
using Studio_Chen.Data.Models;
using Studio_Chen.Core.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Studio_Chen.Data.MockData;

namespace Studio_Chen.TEST
{
    public class TeacherControllerTest
    {
        private readonly TeacherController _teacherController;
        private readonly ITeacherService _teacherService;

        public TeacherControllerTest()
        {
            // כאן תוכל להוסיף Mock או Fake של ITeacherService
            _teacherService = new FakeTeacherService(); // דוגמה, תחליף ביישום שלך
            _teacherController = new TeacherController(_teacherService);
        }

        [Fact]
        public async Task GetAll_ReturnsOk()
        {
            //Arrange
            //Act
            var result = await _teacherController.GetAsync();
            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var teachers = Assert.IsType<List<Teacher>>(okResult.Value);
            Assert.NotNull(teachers);
        }

        [Fact]
        public async Task GetAll_ReturnsCount()
        {
            //Arrange
            //Act
            var result = await _teacherController.GetAsync();
            //Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var teachers = Assert.IsType<List<Teacher>>(okResult.Value);
            Assert.Equal(2, teachers.Count);
        }

        [Fact]
        public async Task Get_ReturnsOk()
        {
            //Arrange
            int id = 1;
            //Act
            var result = await _teacherController.GetAsync(id);
            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task Get_NotFound()
        {
            //Arrange
            int id = 100;
            //Act
            var result = await _teacherController.GetAsync(id);
            //Assert
            Assert.IsType<NotFoundResult>(result);
        }
    }
}
