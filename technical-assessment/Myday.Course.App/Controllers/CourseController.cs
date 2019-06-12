using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Myday.Course.App.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCourse()
        {
            var courses = new List<object>() { new { Id = Guid.NewGuid(), Name = "MydayDev", Description = "Lorum ipsum", StartDate = DateTime.Now, Duration = "6 Months" } };
            return new OkObjectResult(courses);
        }
    }
}