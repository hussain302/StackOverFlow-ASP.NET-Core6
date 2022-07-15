using StackOverFlow.DataBase.Blogs;
using StackOverFlow.DataBase.Users;
using StackOverFlow.Models.Blogs;

namespace StackOverFlow.Mappers
{
    public static class CommentMapper
    {
        public static CommentModel ConvertToWebModel(this Comment source)
        {
            return new CommentModel
            {
                Id = source.Id,
                MainComment = source.MainComment,
            };
        }
        
        public static Comment ConvertToDomainModel(this CommentModel source)
        {
            return new Comment
            {
                Id = source.Id,
                MainComment = source.MainComment,              
            };
        }
    }
}