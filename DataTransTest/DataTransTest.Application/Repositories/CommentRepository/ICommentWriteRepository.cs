using Core.Persistence.Repositories.Interface;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Repositories.CommentRepository
{
    public interface ICommentWriteRepository : IWriteRepository<Comment>
    {
    }
}