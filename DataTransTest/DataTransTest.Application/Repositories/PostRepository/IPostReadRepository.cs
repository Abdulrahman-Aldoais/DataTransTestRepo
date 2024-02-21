using Core.Persistence.Repositories.Interface;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Repositories.PostRepository
{
    public interface IPostReadRepository : IReadRepository<Post>
    {
    }
}