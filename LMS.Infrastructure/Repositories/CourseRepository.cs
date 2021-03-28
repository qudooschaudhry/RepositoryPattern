using LMS.Domain;
using LMS.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public async Task<Course> GetById(Guid id, CancellationToken cancellationToken)
        {
            await Task.Delay(0, cancellationToken);
            return _context.Courses
                .Include(c => c.Chapters)
                .FirstOrDefault(c => c.Id == id);
        }
        public async Task<IEnumerable<Course>> GetAll(CancellationToken cancellationToken)
        {
            await Task.Delay(0, cancellationToken);
            return _context.Courses.OrderBy(c => c.Name).ToList();
        }
        public async Task Add(Course entity, CancellationToken cancellationToken)
        {
            await _context.Courses.AddAsync(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
        public async Task Save(Course entity, CancellationToken cancellationToken)
        {
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task Delete(Course entity, CancellationToken cancellationToken)
        {
            _context.Courses.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
