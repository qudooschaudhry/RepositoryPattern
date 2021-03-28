using LMS.Infrastructure.Repositories;
using LMS.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LMS.UI.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var courses = await _courseRepository.GetAll(cancellationToken);
            
            return View(courses.Select(c => new CourseItemModel() 
            { 
                Id = c.Id,
                Name = c.Name,
                Startdate = c.StartDate,
                EndDate = c.EndDate
            }));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetById(id, cancellationToken);

            return View(new EditCourseViewModel() 
            { 
                Id = course.Id,
                Name = course.Name,
                StartDate = course.StartDate, 
                EndDate = course.EndDate
            });
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCourseViewModel viewModel, CancellationToken cancellationToken)
        {
            var course = await _courseRepository.GetById(viewModel.Id, cancellationToken);

            course.Update(viewModel.Name, viewModel.Description);

            await _courseRepository.Save(course, cancellationToken);

            return View(viewModel);
        }
    }
}
