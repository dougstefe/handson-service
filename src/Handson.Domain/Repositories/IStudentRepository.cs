using Handson.Domain.Entities;

namespace Handson.Domain.Repositories
{
    public interface IStudentRepository
    {
        void Add(Student student);
        void Update(Student student);
        Task<Student?> FindById(Guid id);
        Task<Student?> FindByEmail(string email);
    }
}
