using StackOverFlow.DataBase;
using StackOverFlow.DataBase.Blogs;
using StackOverFlow.Interfaces.BlogInterfaces;

namespace StackOverFlow.DataAccess.BlogRepositories
{
    public class CategoryRepository : ICategoryRepository
    {

        private readonly BlogContext context;

        public CategoryRepository(BlogContext context)
        {
            this.context = context;
        }
        public void AddCategory(Category Category)
        {
            if(Category != null)
            {
                context.Add(Category);
                context.SaveChanges();
            }
        }

        public Category GetCategory(int CategoryId)
        {
           return context.Categories.Where(c => c.Id == CategoryId).FirstOrDefault();
        }

        public IEnumerable<Category> GetCategorys()
        {
            return context.Categories.ToList();
        }

        public void RemoveCategory(int CategoryId)
        {
            context.Remove(GetCategory(CategoryId));
            context.SaveChanges();
        }
        public void UpdateCategory(Category Category)
        {
            context.Update(Category);
            context.SaveChanges();
        }
    }
}
