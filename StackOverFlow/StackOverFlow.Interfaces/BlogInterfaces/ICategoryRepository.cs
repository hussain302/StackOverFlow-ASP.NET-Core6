using StackOverFlow.DataBase.Blogs;


namespace StackOverFlow.Interfaces.BlogInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategorys();
        public Category GetCategory(int CategoryId);
        public void UpdateCategory(Category Category);
        public void RemoveCategory(int CategoryId);
        public void AddCategory(Category Category);
    }
}