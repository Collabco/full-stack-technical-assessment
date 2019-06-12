using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Myday.Course.App.Controllers;
using System;
using Xunit;

namespace Myday.Course.App.Tests.Controllers
{
    public class CourseControllerTests : IDisposable
    {
        private MockRepository mockRepository;

        public CourseControllerTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private CourseController CreateCourseController()
        {
            return new CourseController();
        }

        [Fact]
        public async void GetCourse_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateCourseController();

            // Act
            var result = (await unitUnderTest.GetCourse()) as ObjectResult;

            // Assert
            Assert.Equal(StatusCodes.Status200OK, result.StatusCode);
        }
    }
}