using StackOverFlow.Models.Users;

namespace StackOverFlow.Models.Blogs
{
    public class BlogModel
    {

        public int Id { get; set; }
        
  
        public string Title { get; set; }


        public string? Description { get; set; }

        public string? ImageURL { get; set; }


        public int? CategoryId { get; set; }
        public virtual CategoryModel? Category { get; set; }


        public int? UserId { get; set; }
        public virtual UserModel? User { get; set; }
        public int? CommentId { get; set; }
        public virtual CommentModel? Comment { get; set; } = null;

    }
}
