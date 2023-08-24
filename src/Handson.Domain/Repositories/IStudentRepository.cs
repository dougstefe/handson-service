using Handson.Domain.Entities;

namespace Handson.Domain.Repositories
{
    public interface IStudentRepository
    {
        Task Add(Student student);
        Task Update(Student student);
        Task FindById(Guid id);
        Task FindByEmail(string email);
    }
}
