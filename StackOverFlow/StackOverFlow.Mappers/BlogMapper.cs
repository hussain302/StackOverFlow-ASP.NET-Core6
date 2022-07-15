using StackOverFlow.DataBase.Blogs;
using StackOverFlow.DataBase.Users;
using StackOverFlow.Models.Blogs;

namespace StackOverFlow.Mappers
{
    public static class BlogMapper
    {
        public static BlogModel ConvertToWebModel(this Blog source)
        {
            return new BlogModel
            {
                Id = source.Id,
                Category = source.Category.ConvertToWebModel(),
                Comment = (source.Comment != null) ? source.Comment.ConvertToWebModel() : null,
                Description = source.Description,
                ImageURL = source.ImageURL,
                User = source.User.ConvertToWebModel(),
                Title = source.Title
            };
        }

        public static Blog ConvertToDomainModel(this BlogModel source)
        {
            return new Blog
            {
                Id = source.Id,
                CategoryId = source.CategoryId,
                CommentId = source.CommentId,
                Description = source.Description,
                ImageURL = source.ImageURL,
                UserId = source.UserId,
                Title = source.Title
            };
        }


    }
}