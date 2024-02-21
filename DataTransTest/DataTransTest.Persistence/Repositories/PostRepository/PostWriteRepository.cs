
using Core.Persistence.Repositories.Abstracts;
using DataTransTest.Application.Repositories.PostRepository;
using DataTransTest.Domain.Entity;
using DataTransTest.Persistence.DataBase;

namespace DataTransTest.Persistence.Repositories.PostRepository
{
    public class PostWriteRepository : WriteRepository<Post, ApplicationDbContext>, IPostWriteRepository
    {
        public PostWriteRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}