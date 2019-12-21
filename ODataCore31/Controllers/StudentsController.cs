using System;
using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataCore31.Models;

namespace ODataCore31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: api/Students
        [HttpGet]
        [EnableQuery()]
        public IEnumerable<Student> Get()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Vishwa Goli",
                    Score = 100
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "Josh McCall",
                    Score = 120
                }
            };
        }
    }
}
