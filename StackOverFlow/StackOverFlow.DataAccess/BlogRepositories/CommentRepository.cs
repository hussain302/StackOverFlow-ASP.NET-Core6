using StackOverFlow.DataBase;
using StackOverFlow.DataBase.Blogs;
using StackOverFlow.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace StackOverFlow.DataAccess.BlogRepositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly BlogContext context;
        public CommentRepository(BlogContext context)
        {
            this.context = context;
        }

        public void AddComment(Comment Comment)
        {
            context.Add(Comment);
            context.SaveChanges();
        }

        public Comment GetComment(int CommentId)
        {
            //(from c in context.comments where c.Id == CommentId).FirstOrDefault();

            return context.comments
                .Where(x=>x.Id == CommentId).FirstOrDefault();

           // return context.comments.Find(CommentId);

        }
        public IEnumerable<Comment> GetComments()
        {
            return context.comments.ToList();
        }

        public void RemoveComment(int CommentId)
        {
            if(CommentId > 0)
            {
                context.Remove(GetComment(CommentId));
                context.SaveChanges();
            }
        }
        public void UpdateComment(Comment Comment)
        {
            if(Comment != null)
            {
                context.Update(Comment);
                context.SaveChanges();
            }
        }
    }
}
