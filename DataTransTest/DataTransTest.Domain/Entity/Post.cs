
namespace DataTransTest.Domain.Entity
{
    public class Post
    {
        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public Post(int id, int userId, int categoryId, string title, string content, bool isPublished, int createdById, DateTime creationTime, DateTime? updationDate, int? updatedById)
        {
            UserId = userId;
            Title = title;
            Content = content;
            IsPublished = isPublished;
            CreatedById = createdById;
            UpdatedById = updatedById;
            CreationDate = creationTime;

        }
        public int Id { get; set; }
        public int UserId { get; set; }
        //public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsPublished { get; set; }
        public int CreatedById { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime CreationDate { get; set; }
        public User Users { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }
}