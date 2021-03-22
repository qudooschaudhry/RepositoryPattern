using LMS.Domain;
using LMS.Infrastructure.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infrastructure.Repositories
{
    public interface ICourseRepository : IRepository<Course>
    { 
    }
    public class CourseRepository : ICourseRepository
    {
        private readonly LMSContext _context;

        public CourseRepository(LMSContext context)
        {
            _context = context;
        }
       
        public async Task<Course> GetById(Guid id)
        {
            await Task.Delay(0);
            return _context.Courses.FirstOrDefault(c => c.Id == id);
        }
        public async Task<IEnumerable<Course>> GetAll()
        {
            await Task.Delay(0);
            return _context.Courses.ToList();
        }
        public Task Add(Course entity)
        {
            throw new NotImplementedException();
        }
        public Task Save(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
