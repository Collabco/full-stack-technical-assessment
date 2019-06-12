using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;


namespace CourseApi
{
    public static class CourseHttpTrigger
    {
        private static Random random = new Random();

        [FunctionName("GetCourses")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "v1/Course")] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("GetCourses Triggered.");

            var randomNumber = random.Next(1, 10);
            switch (randomNumber)
            {
                case 1:
                    return new StatusCodeResult(401);
                case 2:
                    return new StatusCodeResult(500);
                default:

                    var courseFilePath = Environment.GetEnvironmentVariable("CourseFilePath");
                    if (string.IsNullOrEmpty(courseFilePath))
                    {
                        return new StatusCodeResult(500);
                    }

                    var file = await File.ReadAllBytesAsync(courseFilePath);
                    return new FileContentResult(file, "application/json");

            }
        }
    }
}
