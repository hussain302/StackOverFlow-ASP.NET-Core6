using StackOverFlow.DataBase.Blogs;


namespace StackOverFlow.Interfaces.BlogInterfaces
{
    public interface ICommentRepository
    {
        public IEnumerable<Comment> GetComments();
        public Comment GetComment(int CommentId);
        public void UpdateComment(Comment Comment);
        public void RemoveComment(int CommentId);
        public void AddComment(Comment Comment);

    }
}
