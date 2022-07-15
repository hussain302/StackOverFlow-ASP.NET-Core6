using StackOverFlow.DataBase;
using StackOverFlow.DataBase.Blogs;
using StackOverFlow.Interfaces.BlogInterfaces;

namespace StackOverFlow.DataAccess.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext context;
        public BlogRepository(BlogContext context)
        {
            this.context = context;
        }

        public void AddBlog(Blog Blog)
        {
            context.Add(Blog);
            context.SaveChanges();
        }

        public Blog GetBlog(int BlogId)
        {
            return context.Blogs
                .Where(x => x.Id == BlogId).FirstOrDefault();
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return context.Blogs.ToList();
        }

        public IEnumerable<Blog> GetBlogsbyCategory(Category category)
        {
            return context.Blogs.Where(x=>x.CategoryId == category.Id).ToList();
        }

        public void RemoveBlog(int BlogId)
        {
            context.Remove(GetBlog(BlogId));
            context.SaveChanges();
        }

        public void UpdateBlog(Blog Blog)
        {
            context.Update(Blog);
            context.SaveChanges();
        }
    }
}
