using Core.Persistence.Repositories.Interface;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Repositories.CommentRepository
{
    public interface ICommentReadRepository : IReadRepository<Comment>
    {
    }
}