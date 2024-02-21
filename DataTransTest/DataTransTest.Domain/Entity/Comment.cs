namespace DataTransTest.Domain.Entity
{
    public class Comment
    {
        public Comment() { }

        public Comment(int id, int postId, string fullName, string email, string content, bool isPublish, DateTime creationDate)
        {

            PostId = postId;
            FullName = fullName;
            Email = email;
            Content = content;
            IsPublish = isPublish;
            CreationDate = creationDate;
        }

        public int Id { get; set; }
        public int PostId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }
        public bool IsPublish { get; set; }
        public DateTime CreationDate { get; set; }
        public Post Posts { get; set; }
    }
}