using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UniversityScheduling.API.Controllers
{
    [Produces("application/json")]
    [Route("api/schedules")]
    public class SchedulesController : Controller
    {
        [HttpPost("course/{courseId}")]
        public IActionResult PostCourseId(int courseId)
        {
            return Ok();
        }
    }
}