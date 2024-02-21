
using Core.Persistence.Repositories.Abstracts;
using DataTransTest.Application.Repositories.PostRepository;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;

namespace DataTransTest.Persistence.Repositories.PostRepository
{
    public class PostReadRepository : ReadRepository<Post, ApplicationDbContext>, IPostReadRepository
    {
        public PostReadRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}