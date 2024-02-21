

using Core.Persistence.Repositories.Abstracts;
using DataTransTest.Application.Repositories.CommentRepository;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;

namespace DataTransTest.Persistence.Repositories.CommentRepository
{
    public class CommentWriteRepository : WriteRepository<Comment, ApplicationDbContext>, ICommentWriteRepository
    {
        public CommentWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}