using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Serveses.PostService
{
    public interface IPostService
    {

        Task<List<Post>> GetListAsync();
        Task<Post> AddPostAsync(Post post);



    }
}