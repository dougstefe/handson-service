using Handson.Domain.Entities;
using Handson.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Handson.Infrastructure.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly HandsonDbContext _bdContext;

        public CourseRepository(HandsonDbContext bdContext)
        {
            _bdContext = bdContext;
        }

        public void Add(Course course)
        {
            _bdContext.Courses.Add(course);
            _bdContext.SaveChanges();
        }

        public Task<Course?> FindById(Guid id)
        {
            return _bdContext.Courses.SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task<Course?> FindByName(string name)
        {
            return _bdContext.Courses.SingleOrDefaultAsync(x => x.Name == name);
        }

        public void Update(Course course)
        {
            _bdContext.Courses.Update(course);
            _bdContext.SaveChanges();
        }
    }
}
