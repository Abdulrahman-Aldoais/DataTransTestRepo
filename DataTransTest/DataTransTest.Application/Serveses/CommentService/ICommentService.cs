using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Serveses.CommentService
{
    public interface ICommentService
    {
        Task<Comment> GetAsync(int id);
        Task<List<Comment>> GetListAsync();
        Task<Comment> AddComment(Comment comment);
    }
}