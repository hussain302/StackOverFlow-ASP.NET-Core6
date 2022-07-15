using StackOverFlow.DataBase.Blogs;


namespace StackOverFlow.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public IEnumerable<Blog> GetBlogs();
        public Blog GetBlog(int BlogId);
        public IEnumerable<Blog> GetBlogsbyCategory(Category category);
        public void UpdateBlog(Blog Blog);
        public void RemoveBlog(int BlogId);
        public void AddBlog(Blog Blog);


    }
}
