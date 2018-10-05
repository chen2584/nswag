using System;
using Microsoft.AspNetCore.Mvc;
using TestNSwag.Models;

namespace MyApi {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase {
        
        [HttpPost]
        public ActionResult<Student> Add(Student student) {
            student.Id = Guid.NewGuid().ToString("N");
            return student;
        }
    }
}