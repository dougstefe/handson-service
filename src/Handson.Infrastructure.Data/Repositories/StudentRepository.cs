using Handson.Domain.Entities;
using Handson.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Handson.Infrastructure.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly HandsonDbContext _dbContext;

        public StudentRepository(HandsonDbContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext);
            _dbContext = dbContext;
        }

        public void Add(Student student)
        {
            _dbContext.Students.Add(student);
            _dbContext.SaveChanges();
        }

        public Task<Student?> FindByEmail(string email)
        {
            return _dbContext.Students.SingleOrDefaultAsync(x => x.Email.ToString() == email);
        }

        public Task<Student?> FindById(Guid id)
        {
            return _dbContext.Students.SingleOrDefaultAsync(x => x.Id == id);
        }

        public void Update(Student student)
        {
            _dbContext.Students.Update(student);
            _dbContext.SaveChanges();
        }
    }
}
