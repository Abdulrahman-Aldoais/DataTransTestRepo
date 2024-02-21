using DataTransTest.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataTransTest.Persistence.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.Property(u => u.UserId);
            builder.Property(u => u.Title).IsRequired(true).HasMaxLength(500);
            builder.Property(u => u.Content).IsRequired(true);
            builder.Property(u => u.IsPublished).IsRequired(true);
            builder.Property(u => u.UpdatedById).IsRequired(false);
            builder.Property(u => u.CreatedById).IsRequired(true);
            builder.Property(i => i.CreationDate).IsRequired(true);

            builder.HasOne(u => u.Users);
            builder.HasMany(u => u.Comments).WithOne(x => x.Posts).OnDelete(DeleteBehavior.Restrict).HasForeignKey(x => x.PostId);


            builder.HasData(
                new Post
                {
                    Id = 1,
                    UserId = 1,
                    Title = "داتا ترانس",
                    Content = "منشور تجريبي",
                    IsPublished = true,
                    CreatedById = 1,
                    CreationDate = DateTime.UtcNow
                });
        }
    }
}
