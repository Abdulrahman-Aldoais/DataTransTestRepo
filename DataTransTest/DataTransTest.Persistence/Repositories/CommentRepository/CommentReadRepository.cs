using Core.Persistence.Repositories.Abstracts;
using DataTransTest.Application.Repositories.CommentRepository;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;

namespace DataTransTest.Persistence.Repositories.CommentRepository
{
    public class CommentReadRepository : ReadRepository<Comment, ApplicationDbContext>, ICommentReadRepository
    {
        public CommentReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}