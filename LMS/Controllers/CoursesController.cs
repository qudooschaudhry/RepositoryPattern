//using LMS.Domain;
//using LMS.Infrastructure.Repositories;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace LMS.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CoursesController : ControllerBase
//    {
//        private readonly ICourseRepository _courseRepository;

//        public CoursesController(ICourseRepository courseRepository)
//        {
//            _courseRepository = courseRepository;
//        }

//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Course>>> Get()
//        {
//            var courses = await _courseRepository.GetAll();

//            return Ok(courses);
//        }

//        [HttpGet, Route("{id}")]
//        public async Task<ActionResult<Course>> Get(Guid id)
//        {
//            var course = await _courseRepository.GetById(id);

//            if (course == null)
//                return NotFound();

//            return Ok(course);
//        }
//    }
//}
