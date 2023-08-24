using Handson.Domain.Entities;

namespace Handson.Domain.Repositories
{
    public interface ICourseRepository
    {
        Task Add(Course course);
        Task Update(Course course);
        Task FindById(Guid id);
        Task FindByName(string name);
    }
}
