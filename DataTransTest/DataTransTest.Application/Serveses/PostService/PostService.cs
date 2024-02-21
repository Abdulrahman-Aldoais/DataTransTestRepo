using DataTransTest.Application.Repositories.PostRepository;
using DataTransTest.Domain.Entity;

namespace DataTransTest.Application.Serveses.PostService
{
    public class PostService : IPostService
    {
        private readonly IPostReadRepository _postReadRepository;
        private readonly IPostWriteRepository _postWriteRepository;

        public PostService(
            IPostReadRepository postReadRepository,
            IPostWriteRepository postWriteRepository
            )
        {
            _postReadRepository = postReadRepository;
            _postWriteRepository = postWriteRepository;
        }

        public async Task<Post> AddPostAsync(Post post)
        {


            var addedPost = await _postWriteRepository.AddAsync(post);
            return addedPost;

        }

        public async Task<List<Post>> GetListAsync()
        {
            var query = await _postReadRepository.GetListAsync();
            return query.ToList();
        }


    }
}