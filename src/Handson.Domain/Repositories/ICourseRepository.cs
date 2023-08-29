using Handson.Domain.Entities;

namespace Handson.Domain.Repositories
{
    public interface ICourseRepository
    {
        void Add(Course course);
        void Update(Course course);
        Task<Course?> FindById(Guid id);
        Task<Course?> FindByName(string name);
    }
}
