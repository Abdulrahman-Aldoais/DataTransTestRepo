using Core.Persistence.Repositories.Interface;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Repositories.PostRepository
{
    public interface IPostWriteRepository : IWriteRepository<Post>
    {
    }
}