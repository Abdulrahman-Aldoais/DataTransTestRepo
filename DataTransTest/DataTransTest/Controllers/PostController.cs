using DataTransTest.Application.Serveses.CommentService;
using DataTransTest.Application.Serveses.PostService;
using DataTransTest.Domain.Entity;
using Microsoft.AspNetCore.Mvc;

namespace DataTransTest.Controllers
{
    public class PostController : Controller
    {

        private readonly IPostService _postService;
        private readonly ICommentService _commentService;

        public PostController(IPostService postService, ICommentService commentService)
        {
            _postService = postService;
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {

            var allPost = await _postService.GetListAsync();
            return View(allPost);
        }



        [HttpGet]
        public async Task<IActionResult> AllComments()
        {

            var allComm = await _commentService.GetListAsync();
            return View(allComm);
        }


        [HttpGet]
        public async Task<IActionResult> ViewComment(int id)
        {

            try
            {
                var allComm = await _commentService.GetAsync(id);
                return View(allComm);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }





        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }



        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Post input)
        {


            var post = new Post()
            {
                Comments = input.Comments,
                Title = input.Title,
                Content = input.Content,
                CreationDate = DateTime.Now,
                IsPublished = input.IsPublished,
                UserId = 1,
                CreatedById = 1,
            };
            var result = _postService.AddPostAsync(post);
            if (result == null)
            {
                return View(post);

            }
            return RedirectToAction(nameof(Index));


        }


        [HttpGet]
        public async Task<IActionResult> AddCommend(int id)
        {
            var data = new Comment
            {
                PostId = id
            };
            return View(data);
        }



        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCommend(Comment input)
        {


            var comment = new Comment()
            {
                PostId = input.PostId,
                Content = input.Content,
                Email = input.Email,
                FullName = input.FullName,
                IsPublish = false,
                CreationDate = DateTime.Now,

            };
            var result = _commentService.AddComment(comment);
            if (result == null)
            {
                return View(comment);

            }
            return RedirectToAction(nameof(Index));


        }



    }
}
