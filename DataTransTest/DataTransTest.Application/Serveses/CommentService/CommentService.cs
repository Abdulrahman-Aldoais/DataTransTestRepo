using DataTransTest.Application.Repositories.CommentRepository;
using DataTransTest.Domain.Entity;
using System.Data.Entity;

namespace DataTransTest.Application.Serveses.CommentService
{
    public class CommentService : ICommentService
    {
        private readonly ICommentReadRepository _commentReadRepository;
        private readonly ICommentWriteRepository _commentWriteRepository;
        public CommentService(ICommentReadRepository commentReadRepository, ICommentWriteRepository commentWriteRepository)
        {
            _commentReadRepository = commentReadRepository;
            _commentWriteRepository = commentWriteRepository;
        }

        public async Task<Comment> AddComment(Comment comment)
        {
            var result = await _commentWriteRepository.AddAsync(comment);
            return result;
        }

        public async Task<Comment> GetAsync(int id)
        {
            var query = _commentReadRepository
                .GetAll(x => x.Id == id)
                .Include(x => x.Posts).FirstOrDefault();
            return query;
        }






        public async Task<List<Comment>> GetListAsync()
        {
            var query = await _commentReadRepository.GetListAsync();
            return query.ToList();
        }
    }
}